using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Shape
{
    private string _name;

    public Shape(string name)
    {
        this._name = name;
    }
    public Shape()
    {

    }
    public abstract void Draw();
}

