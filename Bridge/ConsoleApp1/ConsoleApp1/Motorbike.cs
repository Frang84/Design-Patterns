using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Motorbike : Vehicle
    {
        public Motorbike() 
        {
            this._type = "Motorbike";
            this._wheelNum = 2;
            this._doorNum = 0;
            this._polish = false;
            this._dirty = true;
            this._dents = false;

        }
    }
}
