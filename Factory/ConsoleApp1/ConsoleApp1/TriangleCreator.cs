using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TriangleCreator : ShapeCreator
{
    public Shape CreateShape()
    {
        return new Triangle(3);
    }
}

