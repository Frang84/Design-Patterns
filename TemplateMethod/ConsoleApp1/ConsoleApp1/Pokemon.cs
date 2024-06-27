using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Pokemon
    {
        private string name;
        private int power;
        private int attack;
        private int defense;

        public Pokemon() 
        {
            Console.WriteLine("pies");
        }

        public string toString()
        {
            string result = "";
            result += ("name: " + name + "\n" + "power: " + power.ToString() + "\n" + "attack: " +
                    attack.ToString() + "\n" + "defense: " + defense.ToString());
            return result;
        }
        public abstract int CalcDamage();
    }
}
