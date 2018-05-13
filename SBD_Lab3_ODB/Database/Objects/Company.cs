using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBD_Lab3_ODB.Database.Objects
{
    public class Company
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public List<Employee> Employees { get; set; }

    }
}
