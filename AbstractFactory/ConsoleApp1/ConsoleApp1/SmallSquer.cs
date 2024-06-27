using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SmallSquer : Shape
{
    public SmallSquer() { }
    public SmallSquer(string name) : base(name) { }

    public override void Draw()
    {
        Console.WriteLine("Draw SmallSquer");
    }
}

