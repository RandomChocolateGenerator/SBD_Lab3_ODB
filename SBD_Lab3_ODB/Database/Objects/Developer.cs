using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBD_Lab3_ODB.Database.Objects
{
    public class Developer : Employee
    {
        public ProgrammingLanguage DevelopIn { get; set; }
        public int YearsExperience { get; set; }

        public Developer(string gender) : base(gender)
        {
            Console.WriteLine("Developer2() - gender: " + gender);
        }

        public Developer() 
        {
            Console.WriteLine("Developer()");
        }


        override public void MakeNoise() { Console.WriteLine("Developer.MakeNoise()"); }
    }
    public enum ProgrammingLanguage { CSharp, Java, PHP }
}
