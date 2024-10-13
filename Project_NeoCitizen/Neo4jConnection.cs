using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_NeoCitizen.Models;
using System.Windows.Forms;

namespace Project_NeoCitizen
{
    class Neo4jConnection : IDisposable
    {
        private readonly IDriver _driver;
        public Neo4jConnection()
        {
            var uri = "neo4j+s://6a9d1e25.databases.neo4j.io";
            var user = "neo4j";            
            var password = "ROu0TDunDySRD63bIE16QtTN69KDutFWo68yVfV-brc";  

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
        public async Task<List<Family>> GetAllFamilyWithAddressAsync()
        {
            var families = new List<Family>();

            using (var session = _driver.AsyncSession())
            {
                // Truy vấn để lấy gia đình và địa chỉ liên kết
                var query = @"
                            MATCH (f:Family)-[:LIVING_AT]->(a:Address)
                            RETURN f, a";

                var result = await session.RunAsync(query);

                var records = await result.ToListAsync();

                foreach (var record in records)
                {
                    var familyNode = record["f"].As<INode>();
                    var addressNode = record["a"].As<INode>();

                    var family = new Family
                    {
                        FamilyID = familyNode.Properties["FamilyID"].As<string>(),
                        FamilyName = familyNode.Properties["FamilyName"].As<string>(),
                        Address = new Address
                        {
                            Street = addressNode.Properties["Street"].As<string>(),
                            Ward = addressNode.Properties["Ward"].As<string>(),
                            District = addressNode.Properties["District"].As<string>(),
                            City = addressNode.Properties["City"].As<string>(),
                            Country = addressNode.Properties["Country"].As<string>()
                        }
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
        public async Task AddFamilyWithAddressAsync(string familyID, string familyName, (string Street, string Ward, string District, string City, string Country) address)
        {
            using (var session = _driver.AsyncSession())
            {
                var query = @"
                MERGE (f:Family {FamilyID: $familyID, FamilyName: $familyName})
                MERGE (a:Address {Street: $street, Ward: $ward, District: $district, City: $city, Country: $country})
                MERGE (f)-[:LIVING_AT]->(a)";

                var parameters = new Dictionary<string, object>
                {
                    { "familyID", familyID },
                    { "familyName", familyName },
                    { "street", address.Street },
                    { "ward", address.Ward },
                    { "district", address.District },
                    { "city", address.City },
                    { "country", address.Country }
                };

                await session.RunAsync(query, parameters);
            }
        }


        public async Task EditFamilyWithAddressAsync(string familyID, string familyName, (string Street, string Ward, string District, string City, string Country) address)
        {
            using (var session = _driver.AsyncSession())
            {
                // Cập nhật tên gia đình
                var query = @"
                            MATCH (f:Family {FamilyID: $familyID})
                            SET f.FamilyName = $familyName";
                await session.RunAsync(query, new { familyID, familyName });

                // Tìm địa chỉ cũ và xóa liên kết
                var removeLinkQuery = @"
                                        MATCH (f:Family {FamilyID: $familyID})-[r:LIVING_AT]->(a:Address)
                                        DETACH DELETE r";
                await session.RunAsync(removeLinkQuery, new { familyID });

                // Cập nhật hoặc tạo địa chỉ mới
                var addressQuery = @"
                                    MERGE (a:Address {Street: $street, Ward: $ward, District: $district, City: $city, Country: $country})";
                await session.RunAsync(addressQuery, new
                {
                    street = address.Street,
                    ward = address.Ward,
                    district = address.District,
                    city = address.City,
                    country = address.Country
                });

                // Liên kết gia đình với địa chỉ mới
                var linkQuery = @"
                                MATCH (f:Family {FamilyID: $familyID}), (a:Address {Street: $street, Ward: $ward, District: $district, City: $city, Country: $country})
                                MERGE (f)-[:LIVING_AT]->(a)";
                await session.RunAsync(linkQuery, new
                {
                    familyID,
                    street = address.Street,
                    ward = address.Ward,
                    district = address.District,
                    city = address.City,
                    country = address.Country
                });
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

        public async Task<List<Citizen>> GetAllCitizensWithFamilyAsync(string familyID)
        {
            var citizens = new List<Citizen>();

            using (var session = _driver.AsyncSession())
            {
                var query = @"
            MATCH (c:Citizen)-[:BELONGS_TO]->(f:Family)
            WHERE f.FamilyID = $familyID
            RETURN c, f";

                var result = await session.RunAsync(query, new { familyID });
                var records = await result.ToListAsync();

                foreach (var record in records)
                {
                    var citizenNode = record["c"].As<INode>();
                    var familyNode = record["f"].As<INode>();

                    var citizen = new Citizen
                    {
                        CitizenID = citizenNode.Properties["CitizenID"].As<string>(),
                        FullName = citizenNode.Properties["FullName"].As<string>(),
                        DateOfBirth = citizenNode.Properties["DateOfBirth"].As<string>(),
                        Gender = citizenNode.Properties["Gender"].As<string>(),
                        PhoneNumber = citizenNode.Properties["PhoneNumber"].As<string>(),
                        Family = new Family
                        {
                            FamilyID = familyNode.Properties["FamilyID"].As<string>(),
                            FamilyName = familyNode.Properties["FamilyName"].As<string>()
                        }
                    };

                    citizens.Add(citizen);
                }
            }
            return citizens;
        }
        public async Task<List<Citizen>> GetUnlinkedCitizensAsync()
        {
            var citizens = new List<Citizen>();

            using (var session = _driver.AsyncSession())
            {
                var query = @"
                            MATCH (c:Citizen)
                            WHERE NOT (c)-[:BELONGS_TO]->(:Family)
                            RETURN c";

                var result = await session.RunAsync(query);
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

                    citizens.Add(citizen);
                }
            }

            return citizens;
        }

        public async Task AddCitizenToFamilyAsync(string citizenID, string familyID)
        {
            using (var session = _driver.AsyncSession())
            {
                var query = @"
                            MATCH (c:Citizen {CitizenID: $citizenID}), (f:Family {FamilyID: $familyID})
                            MERGE (c)-[:BELONGS_TO]->(f)";

                await session.RunAsync(query, new { citizenID, familyID });
            }
        }

        public async Task RemoveCitizenFromFamilyAsync(string citizenID, string familyID)
        {
            using (var session = _driver.AsyncSession())
            {
                var query = @"
            MATCH (c:Citizen {CitizenID: $citizenID})-[r:BELONGS_TO]->(f:Family {FamilyID: $familyID})
            DELETE r";

                await session.RunAsync(query, new { citizenID, familyID });
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

        public async Task<List<Address>> SearchAddressAsync(string search, string searchtype)
        {
            var lstadrs = new List<Address>();

            using (var session = _driver.AsyncSession())
            {
                string query = "";

                if (searchtype == "ID Địa Chỉ")
                {
                    query = "MATCH (a:Address) WHERE a.AddressID CONTAINS $search RETURN a";
                }
                else if (searchtype == "Địa Chỉ")
                {
                    query = "MATCH (a:Address) WHERE a.Street CONTAINS $search RETURN a";
                }
                else if (searchtype == "Phường")
                {
                    query = "MATCH (a:Address) WHERE a.Ward CONTAINS $search RETURN a";
                }
                else if (searchtype == "Quận")
                {
                    query = "MATCH (a:Address) WHERE a.District CONTAINS $search RETURN a";
                }
                else if (searchtype == "Thành Phố")
                {
                    query = "MATCH (a:Address) WHERE a.City CONTAINS $search RETURN a";
                }
                else if (searchtype == "Quốc Gia")
                {
                    query = "MATCH (a:Address) WHERE a.Country CONTAINS $search RETURN a";
                }

                var result = await session.RunAsync(query, new { search });

                var records = await result.ToListAsync();

                foreach (var record in records)
                {
                    var addresesNode = record["a"].As<INode>();
                    var address = new Address
                    {
                        AddressID = addresesNode.Properties["AddressID"].As<string>(),
                        Street = addresesNode.Properties["Street"].As<string>(),
                        Ward = addresesNode.Properties["Ward"].As<string>(),
                        District = addresesNode.Properties["District"].As<string>(),
                        City = addresesNode.Properties["City"].As<string>(),
                        Country = addresesNode.Properties["Country"].As<string>()
                    };
                    lstadrs.Add(address);
                }
            }
            return lstadrs;
        }
        public async Task<List<Address>> GetUnlinkedAddressesAsync()
        {
            var addresses = new List<Address>();

            using (var session = _driver.AsyncSession())
            {
                string query = @"
                                MATCH (a:Address)
                                WHERE NOT (a)<-[:LIVING_AT]-(:Family)
                                RETURN a.Street AS Street, a.Ward AS Ward, a.District AS District, a.City AS City, a.Country AS Country";

                var result = await session.RunAsync(query);
                var records = await result.ToListAsync();

                foreach (var record in records)
                {
                    var address = new Address
                    {
                        Street = record["Street"].As<string>(),
                        Ward = record["Ward"].As<string>(),
                        District = record["District"].As<string>(),
                        City = record["City"].As<string>(),
                        Country = record["Country"].As<string>()
                    };
                    addresses.Add(address);
                }
            }
            return addresses;
        }
        public async Task<string> GetNextAddressIDAsync()
        {
            int nextID;
            using (var session = _driver.AsyncSession())
            {
                var query = @"
                        MATCH (a:Address) 
                        RETURN COALESCE(MAX(toInteger(SUBSTRING(a.AddressID, 1))), 0) AS maxID";

                var result = await session.RunAsync(query);
                var record = await result.SingleAsync();

                int maxID = record["maxID"].As<int>();
                nextID = maxID == 0 ? 1 : maxID + 1;

            }
            return $"A{nextID.ToString("D3")}";
        }

        public async Task<bool> AddAddressWithManagerAsync(string street, string ward, string district, string city, string country)
        {
            using (var session = _driver.AsyncSession())
            {
                var checkQuery = @"
                                    MATCH (a:Address)
                                    WHERE toLower(a.Street) = toLower($street) 
                                      AND toLower(a.Ward) = toLower($ward)
                                      AND toLower(a.District) = toLower($district)
                                      AND toLower(a.City) = toLower($city)
                                      AND toLower(a.Country) = toLower($country)
                                    RETURN a";

                var checkResult = await session.RunAsync(checkQuery, new { street, ward, district, city, country });
                var checkRecords = await checkResult.ToListAsync();

                if (checkRecords.Count > 0)
                {
                    MessageBox.Show("Địa chỉ đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                string addressID = await GetNextAddressIDAsync();

                var query = @"
                            CREATE (a:Address {AddressID: $addressID, Street: $street, Ward: $ward, District: $district, City: $city, Country: $country})";

                await session.RunAsync(query, new { addressID, street, ward, district, city, country });

                return true;
            }
        }
        public async Task<bool> EditAddressWithManagerAsync(string addressID, string street, string ward, string district, string city, string country)
        {
            using (var session = _driver.AsyncSession())
            {
                var checkQuery = @"
                                MATCH (a:Address {Street: $street, Ward: $ward, District: $district, City: $city, Country: $country})
                                WHERE a.AddressID <> $addressID
                                RETURN a";

                var checkResult = await session.RunAsync(checkQuery, new { addressID, street, ward, district, city, country });
                var checkRecords = await checkResult.ToListAsync();

                if (checkRecords.Count > 0)
                {
                    MessageBox.Show("Địa chỉ đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                var query = @"
                            MATCH (a:Address {AddressID: $addressID})
                            SET a.Street = $street, a.Ward = $ward, a.District = $district, a.City = $city, a.Country = $country";

                await session.RunAsync(query, new { addressID, street, ward, district, city, country });

                return true;
            }
        }
        public async Task DeleteAddressWithManagerAsync(string addressID)
        {
            using (var session = _driver.AsyncSession())
            {
                var query = @"
                            MATCH (a:Address {AddressID: $addressID })
                            DETACH DELETE a";
                var result = await session.RunAsync(query, new { addressID });
            }
        }

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
