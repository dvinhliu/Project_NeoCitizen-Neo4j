using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_NeoCitizen.Models;

namespace Project_NeoCitizen
{
    class Neo4jConnection : IDisposable
    {
        private readonly IDriver _driver;
        public Neo4jConnection()
        {
            var uri = "bolt://localhost:7687";
            var user = "neo4j";            
            var password = "12345678";  

            _driver = GraphDatabase.Driver(uri, AuthTokens.Basic(user, password));
        }

        //LOGIN
        public async Task<Admin> LoginAsync(string username, string password)
        {
            using (var session = _driver.AsyncSession())
            {
                var result = await session.RunAsync(
                    "MATCH (u:Admin {Username: $username, Password: $password}) RETURN u",
                    new { username, password });

                var records = await result.ToListAsync();

                if (records.Count > 0)
                {
                    var userNode = records[0]["u"].As<INode>();

                    var user = new Admin
                    {
                        AdminID = userNode.Properties["AdminID"].As<string>(),
                        Username = userNode.Properties["Username"].As<string>()
                    };
                    return user;
                }
                return null;
            }
        }

        //Family
        public async Task<List<Family>> GetAllFamilyAsync()
        {
            var families = new List<Family>();

            using (var session = _driver.AsyncSession())
            {
                var result = await session.RunAsync("MATCH (f:Family) RETURN f");

                var records = await result.ToListAsync();

                foreach (var record in records)
                {
                    var familyNode = record["f"].As<INode>();

                    var family = new Family
                    {
                        FamilyID = familyNode.Properties["FamilyID"].As<string>(),
                        FamilyName = familyNode.Properties["FamilyName"].As<string>()
                    };

                    families.Add(family);
                }
            }

            return families;
        }

        public async Task<List<Family>> SearchFamilyAsync(string search, string searchtype)
        {
            var familes = new List<Family>();

            using (var session = _driver.AsyncSession())
            {
                string query = "";

                if (searchtype == "ID Gia Đình")
                {
                    query = "MATCH (f:Family) WHERE f.FamilyID CONTAINS $search RETURN f";
                }
                else if (searchtype == "Tên Gia Đình")
                {
                    query = "MATCH (f:Family) WHERE f.FamilyName CONTAINS $search RETURN f";
                }

                var result = await session.RunAsync(query, new { search });

                var records = await result.ToListAsync();

                foreach (var record in records)
                {
                    var familyNode = record["f"].As<INode>();
                    var family = new Family
                    {
                        FamilyID = familyNode.Properties["FamilyID"].As<string>(),
                        FamilyName = familyNode.Properties["FamilyName"].As<string>()
                    };
                    familes.Add(family);
                }    
            }
            return familes;
        }

        public async Task<string> GetNextFamilyIDAsync()
        {
            int nextID;
            using (var session = _driver.AsyncSession())
            {
                var query = @"
                        MATCH (f:Family) 
                        RETURN COALESCE(MAX(toInteger(SUBSTRING(f.FamilyID, 1))), 0) AS maxID";

                var result = await session.RunAsync(query);
                var record = await result.SingleAsync();

                int maxID = record["maxID"].As<int>();
                nextID = maxID == 0 ? 1 : maxID + 1;

            }
            return $"F{nextID.ToString("D3")}";
        }

        public async Task AddFamilyWithManagerAsync(string familyName)
        {
            string newFamilyID = await GetNextFamilyIDAsync();

            using (var session = _driver.AsyncSession())
            {
                var query = "CREATE (f:Family {FamilyID: $familyID, FamilyName: $familyName})";
                var result = await session.RunAsync(query, new { familyID = newFamilyID, familyName });
            }    
        }
        public async Task EditFamilyWithManagerAsync(string familyID, string familyName)
        {
            using (var session = _driver.AsyncSession())
            {
                var query = @"
                    MATCH (f:Family {FamilyID: $familyID}) 
                    SET f.FamilyName = $familyName";

                var result = await session.RunAsync(query, new { familyID = familyID, familyName = familyName });
            }
        }
        public async Task DeleteFamilyWithManagerAsync(string familyID)
        {
            using (var session = _driver.AsyncSession())
            {
                var query = @"
                        MATCH (f:Family {FamilyID: $familyID})
                        DETACH DELETE f";
                var result = await session.RunAsync(query, new { familyID });
            }
        }

        //Address
        public async Task<List<Address>> GetAllAddressAsync()
        {
            var lstadress = new List<Address>();

            using (var session = _driver.AsyncSession())
            {
                var result = await session.RunAsync("MATCH (a:Address) RETURN a");

                var records = await result.ToListAsync();

                foreach (var record in records)
                {
                    var addressNode = record["a"].As<INode>();

                    var address = new Address
                    {
                        AddressID = addressNode.Properties["AddressID"].As<string>(),
                        Street = addressNode.Properties["Street"].As<string>(),
                        Ward = addressNode.Properties["Ward"].As<string>(),
                        District = addressNode.Properties["District"].As<string>(),
                        City = addressNode.Properties["City"].As<string>(),
                        Country = addressNode.Properties["Country"].As<string>(),
                    };

                    lstadress.Add(address);
                }
            }

            return lstadress;
        }

        public async Task<List<Family>> SearchAddressAsync(string search, string searchtype)
        {
            var familes = new List<Family>();

            using (var session = _driver.AsyncSession())
            {
                string query = "";

                if (searchtype == "ID Gia Đình")
                {
                    query = "MATCH (f:Family) WHERE f.FamilyID CONTAINS $search RETURN f";
                }
                else if (searchtype == "Tên Gia Đình")
                {
                    query = "MATCH (f:Family) WHERE f.FamilyName CONTAINS $search RETURN f";
                }

                var result = await session.RunAsync(query, new { search });

                var records = await result.ToListAsync();

                foreach (var record in records)
                {
                    var familyNode = record["f"].As<INode>();
                    var family = new Family
                    {
                        FamilyID = familyNode.Properties["FamilyID"].As<string>(),
                        FamilyName = familyNode.Properties["FamilyName"].As<string>()
                    };
                    familes.Add(family);
                }
            }
            return familes;
        }

        public async Task<string> GetNextAddressIDAsync()
        {
            int nextID;
            using (var session = _driver.AsyncSession())
            {
                var query = @"
                        MATCH (e:Address) 
                        RETURN COALESCE(MAX(toInteger(SUBSTRING(f.AddressID, 1))), 0) AS maxID";

                var result = await session.RunAsync(query);
                var record = await result.SingleAsync();

                int maxID = record["maxID"].As<int>();
                nextID = maxID == 0 ? 1 : maxID + 1;

            }
            return $"F{nextID.ToString("D3")}";
        }

        public async Task AddAddressWithManagerAsync(string familyName)
        {
            string newFamilyID = await GetNextFamilyIDAsync();

            using (var session = _driver.AsyncSession())
            {
                var query = "CREATE (f:Family {FamilyID: $familyID, FamilyName: $familyName})";
                var result = await session.RunAsync(query, new { familyID = newFamilyID, familyName });
            }
        }
        //public async Task EditFamilyWithManagerAsync(string familyID, string familyname)
        //{
        //    using (var session = _driver.AsyncSession())
        //    {
        //        var query = @"
        //                    MATCH (f:Family {FamilyID: $familyID})
        //                    SET f.FamilyName = $familyname";
        //        var result = await session.RunAsync(query, new { familyID, familyname });

        //    }
        //}
        //public async Task DeleteFamilyWithManagerAsync(string familyID)
        //{
        //    using (var session = _driver.AsyncSession())
        //    {
        //        var query = @"
        //                MATCH (f:Family {FamilyID: $familyID})
        //                DETACH DELETE f";
        //        var result = await session.RunAsync(query, new { familyID });
        //    }
        //}

        //Citizen
        public async Task<List<Citizen>> GetAllCitizenAsync()
        {
            var lstcitizen = new List<Citizen>();

            using (var session = _driver.AsyncSession())
            {
                var result = await session.RunAsync("MATCH (c:Citizen) RETURN c");

                var records = await result.ToListAsync();

                foreach (var record in records)
                {
                    var citizenNode = record["c"].As<INode>();

                    var citizen = new Citizen
                    {
                        CitizenID = citizenNode.Properties["CitizenID"].As<string>(),
                        FullName = citizenNode.Properties["FullName"].As<string>(),
                        DateOfBirth = citizenNode.Properties["DateOfBirth"].As<string>(),
                        Gender = citizenNode.Properties["Gender"].As<string>(),
                        PhoneNumber = citizenNode.Properties["PhoneNumber"].As<string>()
                    };

                    lstcitizen.Add(citizen);
                }
            }

            return lstcitizen;
        }

        //CCCD

        //Employment
        public void Dispose()
        {
            _driver?.Dispose();
        }
    }
}
