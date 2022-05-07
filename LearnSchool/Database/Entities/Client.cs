using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSchool.Database.Entities
{
    public class Client : BaseEntity
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string DateBirth { get; set; }

        public string Email { get; set; }
        public string DateRegister { get; set; }

        public override string ToString() =>
            $"{FirstName} {MiddleName} {LastName}";
    }
}
