using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Limousine : Vehicle
    {
        public Limousine()
        {
            this._type = "Limousine";
            this._wheelNum = 4;
            this._doorNum = 10;
            this._polish = false;
            this._dirty = true;
            this._dents = false;

        }
    }
}
