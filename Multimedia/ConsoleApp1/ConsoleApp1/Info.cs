using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Info
{
    private int _length;
    private string _name = null!;
    private string _description = null!;
    public Info() { }
    public Info(int length, string name, string description)
    {
        _length = length;
        _name = name;
        _description = description;
    }
    public void SetLength(int length) { _length = length; }
    public int Length  { get => _length; }
    public string Name { get => _name; }
    public string Description { get => _description; }
    public void Display()
    {
        Console.WriteLine("length = " + _length);
        Console.WriteLine("name = " + _name);
        Console.WriteLine("description = " + _description);
    }
}

