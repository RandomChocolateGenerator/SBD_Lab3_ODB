﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBD_Lab3_ODB.Database.Objects;
using Sqo;

namespace SBD_Lab3_ODB
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog("male", "Roki", "Coton de tulear");
            var doge = new Doge();

            Console.ReadKey();
        }
    }
}
