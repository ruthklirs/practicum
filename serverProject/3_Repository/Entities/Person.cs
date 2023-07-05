using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repository.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TZ { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MaleOrFemale { get; set; }
        public string HMO { get; set; }
        List<Child> Children { get; set; }
    }
}
