using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Faculty : Composite
{
    public Faculty(string name, string id) : base(name, id){}
    public override void PrintName()
    {
        Console.WriteLine("Faculty name: " + _name);
        base.PrintName();
    }

}

