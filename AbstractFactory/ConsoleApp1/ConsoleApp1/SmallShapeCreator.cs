using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SmallShapeCreator : IShapeCreator
{
    public Shape CreateRectangle()
    {
        return new SmallRectangle();
    }

    public Shape CreateSquer()
    {
        return new SmallSquer();
    }

    public Shape CreateTriangle()
    {
        return new SmallTriangle();
    }
}

