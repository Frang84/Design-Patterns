using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Truck : Vehicle
    {
        public Truck()
        {
            this._type = "Truck";
            this._wheelNum = 6;
            this._doorNum = 2;
            this._polish = false;
            this._dirty = true;
            this._dents = false;

        }

    }
}
