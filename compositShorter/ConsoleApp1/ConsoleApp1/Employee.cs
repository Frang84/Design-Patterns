using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Employee : IComposite
{
    private string _name;
    private string _id;
    private int _hoursWorked;
    public Employee(string name, string id, int hoursWorked) 
    {
        _name = name;
        _id = id;
        _hoursWorked = hoursWorked;
    }
    public int GetHoursWorked()
    {
        return _hoursWorked;
    }

    public string GetId()
    {
        return _id;
    }

    public void PrintName()
    {
        Console.WriteLine("\t\t\t\t" + _name); ;
    }
}

