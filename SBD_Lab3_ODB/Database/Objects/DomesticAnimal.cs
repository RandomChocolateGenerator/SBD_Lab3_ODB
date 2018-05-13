using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBD_Lab3_ODB.Database.Objects
{
    class DomesticAnimal : Animal
    {
        private string _name;
        private string _race;

        public string Name { get => _name; set => _name = value; }
        public string Race { get => _race; }

        public DomesticAnimal(string gender, string name, string race) : base(gender)
        {
            _name = name;
            _race = race;
        }

    }
}
