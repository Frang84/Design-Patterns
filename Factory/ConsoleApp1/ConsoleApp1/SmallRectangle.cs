using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SmallRectangle : Shape
{
    public SmallRectangle() { }
    public SmallRectangle(int num) : base(num) { }
    public override void Draw()
    {
        Console.WriteLine("Small Rectangle, angle num :" + this._angles);
    }
}
