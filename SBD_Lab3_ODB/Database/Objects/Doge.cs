using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBD_Lab3_ODB.Database.Objects
{
    class Doge : Dog
    {
        public Doge() : base("male", "Doge", "Doge")
        {
            
        }

        


        override public void MakeNoise() {
            Console.WriteLine("");
            Console.WriteLine("                   ▄              ▄");
            Console.WriteLine("                  ▌▒█           ▄▀▒▌");
            Console.WriteLine("                  ▌▒▒█        ▄▀▒▒▒▐");
            Console.WriteLine("                 ▐▄▀▒▒▀▀▀▀▄▄▄▀▒▒▒▒▒▐");
            Console.WriteLine("               ▄▄▀▒░▒▒▒▒▒▒▒▒▒█▒▒▄█▒▐");
            Console.WriteLine("             ▄▀▒▒▒░░░▒▒▒░░░▒▒▒▀██▀▒▌");
            Console.WriteLine("            ▐▒▒▒▄▄▒▒▒▒░░░▒▒▒▒▒▒▒▀▄▒▒▌");
            Console.WriteLine("            ▌░░▌█▀▒▒▒▒▒▄▀█▄▒▒▒▒▒▒▒█▒▐");
            Console.WriteLine("           ▐░░░▒▒▒▒▒▒▒▒▌██▀▒▒░░░▒▒▒▀▄▌");
            Console.WriteLine("           ▌░▒▄██▄▒▒▒▒▒▒▒▒▒░░░░░░▒▒▒▒▌");
            Console.WriteLine("          ▌▒▀▐▄█▄█▌▄░▀▒▒░░░░░░░░░░▒▒▒▐");
            Console.WriteLine("          ▐▒▒▐▀▐▀▒░▄▄▒▄▒▒▒▒▒▒░▒░▒░▒▒▒▒▌");
            Console.WriteLine("          ▐▒▒▒▀▀▄▄▒▒▒▄▒▒▒▒▒▒▒▒░▒░▒░▒▒▐");
            Console.WriteLine("           ▌▒▒▒▒▒▒▀▀▀▒▒▒▒▒▒░▒░▒░▒░▒▒▒▌");
            Console.WriteLine("           ▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒░▒░▒▒▄▒▒▐");
            Console.WriteLine("            ▀▄▒▒▒▒▒▒▒▒▒▒▒░▒░▒░▒▄▒▒▒▒▌");
            Console.WriteLine("              ▀▄▒▒▒▒▒▒▒▒▒▒▄▄▄▀▒▒▒▒▄▀");
            Console.WriteLine("                ▀▄▄▄▄▄▄▀▀▀▒▒▒▒▒▄▄▀");
            Console.WriteLine("                   ▒▒▒▒▒▒▒▒▒▒▀▀ \n");
            Console.Write("                  Wow, such a database");
        }
        

    }
}
            
