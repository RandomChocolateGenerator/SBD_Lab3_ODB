using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBD_Lab3_ODB.Database.Controllers;
using SBD_Lab3_ODB.Database;
using SBD_Lab3_ODB.Database.Objects;
using Sqo;

namespace SBD_Lab3_ODB
{
    class Program
    {
        static DBController dbcontroller;

        static void Main(string[] args)
        {
            Dog dog = new Dog("male", "Roki", "Coton de tulear");
            Cat cat = new Cat("female", "Dafne", "British Shorthair");

            Siaqodb siaqodb = SiaqodbFactory.GetInstance();

            siaqodb.StoreObject(dog);


            SiaqodbFactory.CloseDatabase();

            //Siaqodb db = new Siaqodb();
            //db.
            //dbcontroller = new DBController("/DBFiles");
            //dbcontroller.Add(dog);
            //dbcontroller.Add(cat);

            //dbcontroller.printDB();

            //Console.ReadKey();
        }
    }
}
