using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PaintShop
    {
        private Vehicle vehicle;
        public PaintShop(Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public void PaintWork()
        {
            Console.WriteLine("Paint Work");
          
            
        }
        public void PolishWork()
        {
            Console.WriteLine("Polish Work");
            vehicle._polish = true;
        }
        public void RemoveDentsWork()
        {
            Console.WriteLine("Remove Dents Work");
            vehicle._dents = false;
        }
    }
}
