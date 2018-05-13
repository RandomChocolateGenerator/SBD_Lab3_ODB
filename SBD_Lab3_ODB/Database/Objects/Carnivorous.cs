using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBD_Lab3_ODB.Database.Objects
{
    class Carnivorous : Animal
    {
        public Carnivorous(string gender) : base(gender)
        {
        }

        public bool Hunt(Animal target)
        {
            int val = new Random().Next(0, 1);
            if (val == 0)
            {
                target.Die();
                this.Eat(100);
                return true;
            }
            else
            {
                this.Energy -= 20;
                return false;
            }
        }
    }
}
