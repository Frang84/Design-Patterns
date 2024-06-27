using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Multimedia
{
    protected Info _info = null!;
    protected int _yearOfPremier;

    public Multimedia() { }

    public Multimedia(Info info, int yearOfPremier)
    {
        _info = info;
        _yearOfPremier = yearOfPremier;
    }

    public abstract Multimedia Clone();

    public abstract string toString();
    



}

