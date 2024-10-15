using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_NeoCitizen.Models
{
    class Citizen
    {
        public string CitizenID { get; set; }
        public string FullName { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public Family Family { get; set; }
        public Employment Employment { get; set; }
        public Address Address { get; set; }
        public IdentityCard IdentityCard { get; set; }
        public string JobID { get; set; }                // ID của công việc
        public string IdentityCardID { get; set; }       // ID của thẻ căn cước
        public string AddressID { get; set; }
        public string IDFullName_ToString()
        {
            return $"{CitizenID} - {FullName}";
        }
    }
}
