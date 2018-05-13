using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBD_Lab3_ODB.Database.Objects
{
    abstract class Animal
    {
        private string _gender;
        private DateTime _born;
        private DateTime _death;
        private int _thirst;
        private int _hunger;
        private int _energy;
        private bool _isDead;

        public Animal(string gender)
        {
            _born = DateTime.Now;
            _gender = gender;
        }

        public Animal()
        {
            _born = DateTime.Now;
            _gender = "unknown";
        }


        public DateTime Death { get => _death; }
        public DateTime Born { get => _born; }
        public string Gender { get => _gender; }
        public int Thirst { get => _thirst; }
        public int Hunger { get => _hunger; }

        public bool IsDead { get => _isDead;}
        public int Energy { get => _energy; set => _energy = value; }

        public bool Drink(int amount)
        {
            var ret = false;
            if (amount > _thirst)
            {
                _thirst = 0;
                ret = true;
            } 
            else if (amount > 0)
            {
                _thirst -= amount;
                ret = true;
            }
            return ret;
        }

        public bool Eat(int amount)
        {
            var ret = false;
            if (amount > _hunger)
            {
                _hunger = 0;
                ret = true;
            }
            else if (amount > 0)
            {
                _hunger -= amount;
                ret = true;
            }
            return ret;
        }

        public void Eat(Animal target)
        {
            target.Die();
            _hunger = 0;
        }

        public bool Sleep(int hours)
        {
            var ret = true;
            Energy = (int)Math.Abs(hours * 12.5);
            if (Energy > 100) Energy = 100;
            else if
                (Energy < 0) Energy = 0;
            else ret = false;

            return ret;           
        }

        public bool Die()
        {
            _isDead = true;
            _death = DateTime.Now;

            return true;
        }

        virtual public void MakeNoise() { Console.WriteLine("Animal.MakeNoise()"); }

        public override string ToString()
        {
            return "data ur.: " + this.Born + ", plec: " + this.Gender + ", klasa: " + this.GetType().Name;
        }


        //public string getName()
        //{
        //    return typeof(this.getType).Name;
        //}
    }
}
