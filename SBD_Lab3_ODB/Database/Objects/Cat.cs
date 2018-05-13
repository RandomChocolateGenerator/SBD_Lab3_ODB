using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBD_Lab3_ODB.Database.Objects
{
    class Cat : DomesticAnimal
    {
        

        public Cat(string gender, string name, string race) : base(gender, name, race)
        {
        }

        public Cat()
        {
        }

        override public void MakeNoise() { Console.WriteLine("Meow!"); }
    }
}
