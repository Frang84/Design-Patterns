using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Decorator : Component
{
    protected Component _component;

    public Decorator(Component component)
    {
       this._component = component;
    }
    public void AddComponent(Component component)
    {
        _component = component;
    }
    public override string OperationBike()
    {
        if (_component != null) 
        {
            return this._component.OperationBike();
        }
        else
        {
            return String.Empty;
        }
        
    }
}

