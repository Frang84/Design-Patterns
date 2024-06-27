using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PoisonPokemon : Pokemon
    {
        public override int CalcDamage()
        {
            return 2;
        }
    }
}
