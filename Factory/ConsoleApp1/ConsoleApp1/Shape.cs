using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Shape  
{
    protected int _angles;
    public Shape() { }
    public Shape(int angles)
    {
        _angles = angles;
    }
    public abstract void Draw();
}

