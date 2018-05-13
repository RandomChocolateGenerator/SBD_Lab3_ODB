using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBD_Lab3_ODB.Database.Objects
{
    class WildCat : Animal
    {
        

        public WildCat(string gender) : base(gender)
        {
        }

        public WildCat()
        {
        }

        override public void MakeNoise() { Console.WriteLine("Loud MEOW!"); }
    }
}
