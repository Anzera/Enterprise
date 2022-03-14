using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Comments { get; set; }
        public string Earnings { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public DateTime? DateOfRelease { get; set; }
    }
}
