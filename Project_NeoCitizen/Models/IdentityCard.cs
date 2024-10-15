using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_NeoCitizen.Models
{
    class IdentityCard
    {
        public string IdentityCardID { get; set; }
        public string DocumentNumber { get; set; }
        public string IssueDate { get; set; }
        public string ExpirationDate { get; set; }
        public string IssuedBy { get; set; }
        public string IDDocument_ToString()
        {
            return $"{IdentityCardID} - {DocumentNumber}";
        }
    }
}
