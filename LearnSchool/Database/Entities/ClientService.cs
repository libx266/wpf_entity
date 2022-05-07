using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSchool.Database.Entities
{
    public class ClientService : BaseEntity
    {
        public string Service { get; set; }
        public string DateStart { get; set; }
        public string Client { get; set; }
    }
}
