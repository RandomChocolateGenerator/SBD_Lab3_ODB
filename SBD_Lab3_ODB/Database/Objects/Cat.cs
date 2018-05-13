using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBD_Lab3_ODB.Database.Objects
{
    class Cat : Animal
    {
        private string _name;

        public Cat(string gender, string name, string race) : base(gender)
        {
        }

        public string Name { get => _name; set => _name = value; }
    }
}
