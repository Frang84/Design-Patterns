using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Saddle : Decorator
{
    public Saddle(Component comp) : base(comp) { }

    public override string OperationBike()
    {
        return $"Saddle {base.OperationBike()}";
    }
}

