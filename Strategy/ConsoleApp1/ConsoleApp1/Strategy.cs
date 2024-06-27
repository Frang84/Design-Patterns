using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface Strategy
    {
       
        public void Sort(ref int[] arr);
    }
}
