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

        public async Task<User> LoginAsync(string username, string password)
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

                    var user = new User
                    {
                        UserID = userNode.Properties["UserID"].As<string>(),
                        Username = userNode.Properties["Username"].As<string>()
                    };
                    return user;
                }
                return null;
            }
        }


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
                        Id = familyNode.Properties["id"].As<string>(),
                        FamilyName = familyNode.Properties["familyName"].As<string>()
                    };

                    families.Add(family);
                }
            }

            return families;
        }

        public async Task<List<Family>> SearchFamilyAsync(string search, string searchtype)
        {
            var familes = new List<Family>;

            using (var session = _driver.AsyncSession())
            {
                var result = ""
            }    
        }
        public void Dispose()
        {
            _driver?.Dispose();
        }
    }
}
