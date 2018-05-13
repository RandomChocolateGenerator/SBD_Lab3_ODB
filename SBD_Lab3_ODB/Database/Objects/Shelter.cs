using SBD_Lab3_ODB.Database.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBD_Lab3_ODB.Database
{
    class Shelter
    {
        public string Name { get; set; }
        public List<Animal> Animals { get; set; }

        public Shelter(string name)
        {
            this.Name = name;
        }

        public Shelter()
        {
        }
    }
}
