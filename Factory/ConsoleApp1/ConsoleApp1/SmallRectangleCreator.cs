using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SmallRectangleCreator : ShapeCreator
{
    public Shape CreateShape()
    {
        return new SmallRectangle(4);
    }
}

