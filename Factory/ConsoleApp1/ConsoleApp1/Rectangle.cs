using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Rectangle : Shape
{
    public Rectangle() { }
    public Rectangle(int angles) : base(angles) { }
    public override void Draw()
    {
        Console.WriteLine("Rectangle angles num: " + _angles);
    }
}

