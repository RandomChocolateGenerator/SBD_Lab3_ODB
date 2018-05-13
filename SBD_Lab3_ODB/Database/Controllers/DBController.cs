using SBD_Lab3_ODB.Database.Objects;
using Sqo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBD_Lab3_ODB.Database.Controllers
{
    class DBController
    {
        private Siaqodb _dbinstance;

        public DBController(string path)
        {
            _dbinstance = new Siaqodb(path);
        }

        public Siaqodb Dbinstance { get => _dbinstance; }

        public void Add(Dog element)
        {
            _dbinstance.StoreObject(element);
        }

        public void printDB()
        {
            var query = from Dog c in _dbinstance select c;
            foreach (Dog c in query)
            {
                Console.WriteLine(c.Born + "" + c.IsDead);
            }
        }
    }
}
