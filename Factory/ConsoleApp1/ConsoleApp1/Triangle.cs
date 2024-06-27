using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Triangle : Shape
{
    public Triangle() { }
    public Triangle(int angles) : base(angles) { }
    public override void Draw()
    {
        Console.WriteLine("Triangle, angles num: " + _angles);
    }
}

