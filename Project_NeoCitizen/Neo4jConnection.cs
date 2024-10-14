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
        public async Task<List<IdentityCard>> GetAllIdentityCardAsync()
        {
            var lstInCard = new List<IdentityCard>();

            using (var session = _driver.AsyncSession())
            {
                var result = await session.RunAsync("MATCH (id:IdentityCard) RETURN DISTINCT id");

                var records = await result.ToListAsync();

                foreach (var record in records)
                {
                    var InCardNode = record["id"].As<INode>();

                    var incard = new IdentityCard
                    {
                        IdentityCardID = InCardNode.Properties["IdentityCardID"].As<string>(),
                        DocumentNumber = InCardNode.Properties["DocumentNumber"].As<string>(),
                        IssueDate = InCardNode.Properties["IssueDate"].As<string>(),
                        ExpirationDate = InCardNode.Properties["ExpirationDate"].As<string>(),
                        IssuedBy = InCardNode.Properties["IssuedBy"].As<string>(),
                        
                    };

                    lstInCard.Add(incard);
                }
            }
            return lstInCard;
        }

        public async Task<List<IdentityCard>> SearchIdentityCardAsync(string search, string searchtype)
        {
            var lstIdCard = new List<IdentityCard>();

            using (var session = _driver.AsyncSession())
            {
                string query = "";

                if (searchtype == "Mã CCCD")
                {
                    query = "MATCH (id:IdentityCard) WHERE id.IdentityCardID CONTAINS $search RETURN id";
                }
                else if (searchtype == "Số CCCD")
                {
                    query = "MATCH (id:IdentityCard) WHERE id.DocumentNumber CONTAINS $search RETURN id";
                }
                else if (searchtype == "Ngày Cấp Phát")
                {
                    query = "MATCH (id:IdentityCard) WHERE id.IssueDate CONTAINS $search RETURN id";
                }
                else if (searchtype == "Ngày Hết Hạn")
                {
                    query = "MATCH (id:IdentityCard) WHERE id.ExpirationDate CONTAINS $search RETURN id";
                }
                else if (searchtype == "Cấp Bởi")
                {
                    query = "MATCH (id:IdentityCard) WHERE id.IssuedBy CONTAINS $search RETURN id";
                }

                var result = await session.RunAsync(query, new { search });

                var records = await result.ToListAsync();

                foreach (var record in records)
                {
                    var InCardNode = record["id"].As<INode>();
                    var IdCard = new IdentityCard
                    {
                        IdentityCardID = InCardNode.Properties["IdentityCardID"].As<string>(),
                        DocumentNumber = InCardNode.Properties["DocumentNumber"].As<string>(),
                        IssueDate = InCardNode.Properties["IssueDate"].As<string>(),
                        ExpirationDate = InCardNode.Properties["ExpirationDate"].As<string>(),
                        IssuedBy = InCardNode.Properties["IssuedBy"].As<string>(),
                    };
                    lstIdCard.Add(IdCard);
                }
            }
            return lstIdCard;
        }

        public async Task<string> GetNextIdentityCardIDAsync()
        {
            int nextID;
            using (var session = _driver.AsyncSession())
            {
                var query = @"
                    MATCH (id:IdentityCard) 
                    RETURN COALESCE(MAX(toInteger(SUBSTRING(id.IdentityCardID, 3))), 0) AS maxID";

                var result = await session.RunAsync(query);
                var record = await result.SingleAsync();

                int maxID = record["maxID"].As<int>();
                nextID = maxID == 0 ? 1 : maxID + 1;
            }

            return $"ID{nextID.ToString("D3")}";
        }

        public async Task AddIdentityCardAsync(string identityCardID, string documentNumber, string issueDate, string expirationDate, string issuedBy)
        {
            using (var session = _driver.AsyncSession())
            {
                var query = @"
                MERGE (id:IdentityCard {IdentityCardID: $identityCardID, DocumentNumber: $documentNumber, IssueDate: $issueDate, ExpirationDate: $expirationDate, IssuedBy: $issuedBy})";

                        var parameters = new Dictionary<string, object>
                {
                    { "identityCardID", identityCardID },
                    { "documentNumber", documentNumber },
                    { "issueDate", issueDate },
                    { "expirationDate", expirationDate },
                    { "issuedBy", issuedBy }
                };

                await session.RunAsync(query, parameters);
            }
        }

        public async Task EditIdentityCardAsync(string identityCardID, string documentNumber, string issueDate, string expirationDate, string issuedBy)
        {
            using (var session = _driver.AsyncSession())
            {
                var query = @"
                MATCH (id:IdentityCard {IdentityCardID: $identityCardID})
                SET id.DocumentNumber = $documentNumber,
                    id.IssueDate = $issueDate,
                    id.ExpirationDate = $expirationDate,
                    id.IssuedBy = $issuedBy";

                        var parameters = new Dictionary<string, object>
                {
                    { "identityCardID", identityCardID },
                    { "documentNumber", documentNumber },
                    { "issueDate", issueDate },
                    { "expirationDate", expirationDate },
                    { "issuedBy", issuedBy }
                };

                await session.RunAsync(query, parameters);
            }
        }

        public async Task DeleteIdentityCardWithManagerAsync(string idCardID)
        {
            using (var session = _driver.AsyncSession())
            {
                var query = @"
                        MATCH (id:IdentityCard {IdentityCardID: $idCardID})
                        DETACH DELETE id";
                var result = await session.RunAsync(query, new { idCardID });
            }
        }





        //Employment
        public async Task<List<Employment>> GetAllEmploymentAsync()
        {
            var lstEmpl = new List<Employment>();

            using (var session = _driver.AsyncSession())
            {
                var result = await session.RunAsync("MATCH (e:Employment) RETURN DISTINCT e");

                var records = await result.ToListAsync();

                foreach (var record in records)
                {
                    var EmplNode = record["e"].As<INode>();

                    var employment = new Employment
                    {
                        EmploymentID = EmplNode.Properties["EmploymentID"].As<string>(),
                        Company = EmplNode.Properties["Company"].As<string>(),
                        Position = EmplNode.Properties["Position"].As<string>(),
                        StartDate = EmplNode.Properties["StartDate"].As<string>(),
                    };

                    lstEmpl.Add(employment);
                }
            }
            return lstEmpl;
        }


        public async Task<List<Employment>> SearchEmploymentAsync(string search, string searchtype)
        {
            var employments = new List<Employment>();

            using (var session = _driver.AsyncSession())
            {
                string query = "";

                if (searchtype == "ID Công Việc")
                {
                    query = "MATCH (e:Employment) WHERE e.EmploymentID CONTAINS $search RETURN e";
                }
                else if (searchtype == "Tên Công Ty")
                {
                    query = "MATCH (e:Employment) WHERE e.Company CONTAINS $search RETURN e";
                }
                else if (searchtype == "Vị Trí")
                {
                    query = "MATCH (e:Employment) WHERE e.Position CONTAINS $search RETURN e";
                }
                else if (searchtype == "Ngày Bắt Đầu Làm Việc")
                {
                    query = "MATCH (e:Employment) WHERE e.StartDate CONTAINS $search RETURN e";
                }
                
                var result = await session.RunAsync(query, new { search });

                var records = await result.ToListAsync();

                foreach (var record in records)
                {
                    var emplNode = record["e"].As<INode>();
                    var empl = new Employment
                    {
                        EmploymentID = emplNode.Properties["EmploymentID"].As<string>(),
                        Company = emplNode.Properties["Company"].As<string>(),
                        Position = emplNode.Properties["Position"].As<string>(),
                        StartDate= emplNode.Properties["StartDate"].As<string>()
                    };
                    employments.Add(empl);
                }
            }
            return employments;
        }

        public async Task DeleteEmploymentWithManagerAsync(string emplID)
        {
            using (var session = _driver.AsyncSession())
            {
                var query = @"
                        MATCH (e:Employment {EmploymentID: $emplID})
                        DETACH DELETE e";
                var result = await session.RunAsync(query, new { emplID });
            }
        }

        public async Task<string> GetNextEmploymentIDAsync()
        {
            int nextID;
            using (var session = _driver.AsyncSession())
            {
                var query = @"
                    MATCH (e:Employment) 
                    RETURN COALESCE(MAX(toInteger(SUBSTRING(e.EmploymentID, 1))), 0) AS maxID";

                var result = await session.RunAsync(query);
                var record = await result.SingleAsync();

                int maxID = record["maxID"].As<int>();
                nextID = maxID == 0 ? 1 : maxID + 1;
            }

            return $"E{nextID.ToString("D3")}";
        }


        public async Task AddEmploymentAsync(string emplID, string company, string position, string startDate)
        {
            using (var session = _driver.AsyncSession())
            {
                var query = @"
                    CREATE (e:Employment {
                        EmploymentID: $emplID, 
                        Company: $company, 
                        Position: $position, 
                        StartDate: $startDate
                    })";

                var parameters = new Dictionary<string, object>
                {
                    { "emplID", emplID },
                    { "company", company },
                    { "position", position },
                    { "startDate", startDate }
                };

                await session.RunAsync(query, parameters);
            }
        }

        public async Task EditEmploymentAsync(string emplID, string company, string position, string startDate)
        {
            using (var session = _driver.AsyncSession())
            {
                var query = @"
                MATCH (e:Employment {EmploymentID: $emplID})
                SET e.Company = $company,
                    e.Position = $position,
                    e.StartDate = $startDate";

                        var parameters = new Dictionary<string, object>
                {
                    { "emplID", emplID },
                    { "company", company },
                    { "position", position },
                    { "startDate", startDate }
                };
                await session.RunAsync(query, parameters);
            }
        }


        //Dispose
        public void Dispose()
        {
            _driver?.Dispose();
        }
    }
}
