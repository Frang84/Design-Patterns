using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Department : Composite
{
    public Department(string name, string id) : base(name, id)
    {
    }
    public override void PrintName()
    {
        Console.WriteLine("\t\t\tDepartment name: " + _name);
        base.PrintName();
    }
}

