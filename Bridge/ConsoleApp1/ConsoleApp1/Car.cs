using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car : Vehicle
    {
        public Car() 
        {
            this._type = "Car";
            this._wheelNum = 4;
            this._doorNum = 5;
            this._polish = false;
            this._dirty = true;
            this._dents = false;

        }
    }
}
