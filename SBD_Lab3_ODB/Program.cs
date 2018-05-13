using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            Console.WriteLine("Wyczyszczenie bazy danych");
            siaqodb.DropType<Shelter>();
            siaqodb.DropType<Dog>();
            siaqodb.DropType<Cat>();
            siaqodb.DropType<WildCat>();
            siaqodb.DropType<Doge>();
            siaqodb.DropType<Animal>();
            siaqodb.DropType<DomesticAnimal>();
            //siaqodb.DropAllTypes(); - nie dziala, niespojnosc w dokumentacji

            Console.WriteLine("Utworzenie obiektow klasy Shelter");
            Shelter shelter1 = new Shelter("ZOO");
            Shelter shelter2 = new Shelter("Internet");

            Console.WriteLine("Utworzenie obiektow zwierzat");
            Dog dog = new Dog("male", "Roki", "Coton de tulear");
            Cat cat = new Cat("female", "Dafne", "British Shorthair");
            Cat cat2 = new Cat("male", "Chester", "None");
            WildCat wildCat = new WildCat("male");
            Doge doge = new Doge();


            Console.WriteLine("Przypisanie zwierzat do schronisk");
            shelter1.Animals = new List<Animal>();
            shelter2.Animals = new List<Animal>();
            shelter1.Animals.Add(dog);
            shelter1.Animals.Add(wildCat);
            shelter1.Animals.Add(cat);
            shelter1.Animals.Add(cat2);
            shelter2.Animals.Add(doge);


            Console.WriteLine("Umieszczenie obiektow schronisk w bazie");
            siaqodb.StoreObject(shelter1);
            siaqodb.StoreObject(shelter2);
           
            siaqodb.Flush();

            Console.WriteLine("Wczytanie wszystkich obiektów z bazy, prezentacja dziedziczenia i polimorfizmu:");
            IObjectList<Shelter> allShelters = siaqodb.LoadAll<Shelter>();
            int s = 0;
            foreach (Shelter sh in allShelters)
            {
                Console.WriteLine(s + ". Schronisko: " + sh.Name + ", lista zwierzat:");
                int a = 0;
                foreach (Animal an in sh.Animals)
                {
                    Console.Write("\t" + a + ". " + an + ", MakeNoise(): ");
                    an.MakeNoise();
                    a++;
                }
                s++;
            }


            Console.WriteLine("\n\nPrezentacja LINQ");


            Console.WriteLine("Wszystkie koty plci zenskiej:");
            var query1 = from Cat anim in siaqodb
                         where anim.Gender == "female"
                         select anim;
            foreach (Cat anim in query1)
            {
                Console.WriteLine("\t" + anim);
            }

            Console.WriteLine("Wszystkie piesely:");
            var query2 = from Doge anim in siaqodb
                         select anim;
            foreach (Doge anim in query2)
            {
                Console.WriteLine("\t" + anim);
            }




            SiaqodbFactory.CloseDatabase();

            Console.ReadKey();
        }
    }
}
