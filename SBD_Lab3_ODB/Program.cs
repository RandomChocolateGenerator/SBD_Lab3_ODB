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

        static void Main(string[] args)
        {
           
            Siaqodb siaqodb = SiaqodbFactory.GetInstance();
            siaqodb.DropType<Shelter>();


            Shelter shelter1 = new Shelter("ZOO");
            Shelter shelter2 = new Shelter("Internet");

            Dog dog = new Dog("male", "Roki", "Coton de tulear");
            Cat cat = new Cat("female", "Dafne", "British Shorthair");
            WildCat wildCat = new WildCat("male");
            Doge doge = new Doge();

            shelter1.Animals = new List<Animal>();
            shelter2.Animals = new List<Animal>();
            shelter1.Animals.Add(dog);
            shelter1.Animals.Add(wildCat);
            shelter1.Animals.Add(cat);
            shelter2.Animals.Add(doge);



            siaqodb.StoreObject(shelter1);
            siaqodb.StoreObject(shelter2);
            
           
            siaqodb.Flush();
            Console.WriteLine("Wczytanie obiektów z bazy:");
            IObjectList<Shelter> allShelters = siaqodb.LoadAll<Shelter>();
            int s = 0;
            foreach (Shelter sh in allShelters)
            {
                Console.WriteLine(s + ". Schronisko: " + sh.Name + ", lista zwierzat:");
                int a = 0;
                foreach (Animal an in sh.Animals)
                {
                    Console.Write("\t" + a + ". Data ur.: " + an.Born + " plec: " + an.Gender + " typ: " + an.GetType().Name + " - MakeNoise: ");
                    an.MakeNoise();
                    a++;
                }
                s++;
            }
            
            SiaqodbFactory.CloseDatabase();

  

            Console.ReadKey();
        }
    }
}
