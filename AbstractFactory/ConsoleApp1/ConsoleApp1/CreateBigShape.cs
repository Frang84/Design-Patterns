using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class CreateBigShape : IShapeCreator
{
    public Shape CreateRectangle()
    {
        return new BigRectangle();
    }

    public Shape CreateSquer()
    {
        return new BigSquer();
    }

    public Shape CreateTriangle()
    {
        return new BigTriangle();
    }
}

