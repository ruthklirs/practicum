using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.Models
{
    public class ChildModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TZ { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int IdFather { get; set; }
        public PersonModel Father { get; set; }
    }
}
