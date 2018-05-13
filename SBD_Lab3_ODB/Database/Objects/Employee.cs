using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBD_Lab3_ODB.Database.Objects
{
    public abstract class Employee
    {
        private string _gender;
        private DateTime _born;

        public string Gender { get => _gender; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public int Age { get; set; }


        public Employee(string gender)
        {
            Console.WriteLine("Employee2() - gender: " + gender);
            _born = DateTime.Now;
            _gender = gender;
        }


        public Employee()
        {
            Console.WriteLine("Employee()");
            _born = DateTime.Now;
            _gender = "unknown";
        }

        virtual public void MakeNoise() { Console.WriteLine("Employee.MakeNoise()"); }

    }
}
