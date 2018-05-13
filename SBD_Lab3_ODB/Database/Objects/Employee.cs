using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBD_Lab3_ODB.Database.Objects
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public int Age { get; set; }

        virtual public void MakeNoise() { Console.WriteLine("Employee.MakeNoise()"); }

    }
}
