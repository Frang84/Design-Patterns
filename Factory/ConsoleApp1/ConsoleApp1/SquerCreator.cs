using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SquerCreator : ShapeCreator
{
    public Shape CreateShape()
    {
        return new Squer(4);
    }
}

