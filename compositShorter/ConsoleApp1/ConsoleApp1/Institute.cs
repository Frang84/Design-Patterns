using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Institute : Composite
{
    public Institute(string name, string id) : base(name, id)
    {
    }
    public override void PrintName()
    {
        Console.WriteLine("\t\tInstitute name: " + _name);
        base.PrintName();
    }
}

