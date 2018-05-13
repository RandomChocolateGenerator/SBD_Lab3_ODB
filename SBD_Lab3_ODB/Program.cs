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
            //Animal animal1 = new Animal("female");

            Siaqodb siaqodb = SiaqodbFactory.GetInstance();

            siaqodb.DropType<Company>();

            //siaqodb.DropType<Dog>();
            //siaqodb.DropType<Cat>();
            //Employee employee1 = new Employee();
            Developer developer = new Developer();
            developer.FirstName = "Developer2";


            Company company = new Company();
            company.Name = "Company1";
            company.Phone = "233-204-235";
            company.Address = "Street of SimpleCompany, nr.1";


            company.Employees = new List<Employee>();
            company.Employees.Add(developer);

            siaqodb.StoreObject(company);

            //siaqodb.StoreObject(cat);
            siaqodb.Flush();


            IObjectList<Company> allCompanies = siaqodb.LoadAll<Company>();
            foreach (Company comp in allCompanies)
            {
                Console.WriteLine("Company: " + comp.Name);


                foreach (Employee emp in comp.Employees)
                {
                    Console.WriteLine("    Employee: " + emp.FirstName + " - MakeNoise: ");
                    emp.MakeNoise();

                }



            }

            //IObjectList<Cat> cats = siaqodb.LoadAll<Cat>();
            //foreach (Cat c in cats)
            //{
            //    Console.WriteLine("Imię kota: " + c.Name);
            //}


            SiaqodbFactory.CloseDatabase();

            //Siaqodb db = new Siaqodb();
            //db.
            //dbcontroller = new DBController("/DBFiles");
            //dbcontroller.Add(dog);
            //dbcontroller.Add(cat);

            //dbcontroller.printDB();

            Console.ReadKey();
        }
    }
}
