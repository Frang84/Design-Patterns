using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Squer : Shape
{
    public Squer() { }
    public Squer(int angles) : base(angles) { }
    public override void Draw()
    {
        Console.WriteLine("Squer, angles num: " + _angles);
    }
}

