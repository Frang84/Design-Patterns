using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RectangleCreator : ShapeCreator
{
    public Shape CreateShape()
    {
        return new Rectangle(4);
    }
    
}

