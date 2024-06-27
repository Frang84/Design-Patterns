using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Composite : IComposite
{
    protected List<IComposite> composites = new List<IComposite>();
    protected string _name;
    protected string _id;

    public Composite(string name, string id)
    {
        this._name = name;
        this._id = id;
    }
    
    public void Add(IComposite composite)
    {
        composites.Add(composite);  
    }
    public void Remove(IComposite composite) 
    {
        composites.Remove(composite);
    }

    public int GetHoursWorked()
    {
        int result = 0;
        foreach (var item in composites)
        {
            result += item.GetHoursWorked();
        }
        return result;  
    }

    public string GetId()
    {
        string result = string.Empty;   
        foreach (var item in composites)
        {
            result = "\t" + result + item.GetId() + "\n"; 
        }
        return result;
    }

    public virtual void PrintName()
    {
        foreach (var item in composites)
        {
            item.PrintName();
        }
    }


}

