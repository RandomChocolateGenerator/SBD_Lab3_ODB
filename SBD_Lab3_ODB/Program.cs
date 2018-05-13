using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBD_Lab3_ODB.Database.Controllers;
using SBD_Lab3_ODB.Database.Objects;
using Sqo;

namespace SBD_Lab3_ODB
{
    class Program
    {
        static DBController dbcontroller;

        static void Main(string[] args)
        {
            var dog = new Dog("male", "Roki", "Coton de tulear");
            //var doge = new Doge();
            var cat = new Cat("female", "Dafne", "British Shorthair");

            dbcontroller = new DBController("/DBFiles");
            dbcontroller.Add(dog);
            //dbcontroller.Add(cat);

            dbcontroller.printDB();

            Console.ReadKey();
        }
    }
}
