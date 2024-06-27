using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class BigSquer : Shape
{
    public BigSquer() : base() { }
    public BigSquer(string name) : base(name) { }

    public override void Draw()
    {
        Console.WriteLine("Big squer");
    }
}

