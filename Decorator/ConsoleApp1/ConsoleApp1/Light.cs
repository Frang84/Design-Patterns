using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Light : Decorator  
{
    public Light (Component component) : base(component) { }

    public override string OperationBike()
    {
        return $"light {base.OperationBike()}";
    }
}

