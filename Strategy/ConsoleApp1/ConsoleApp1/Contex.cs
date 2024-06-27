using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Contex
    {
        public Strategy strategy;
        public Contex(Strategy strategy)
        {
            this.strategy = strategy;
        }
    }
}
