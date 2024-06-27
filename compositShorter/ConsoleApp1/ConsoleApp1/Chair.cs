using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Chair : Composite
{
    public Chair(string name, string id) : base(name, id)
    {
    }
    public override void PrintName()
    {
        Console.WriteLine("\tChair name: " + _name);
        base.PrintName();
    }
}

