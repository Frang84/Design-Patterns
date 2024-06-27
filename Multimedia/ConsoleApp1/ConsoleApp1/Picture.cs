using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Picture : Multimedia
{
    private string _photograph = null!;
    public Picture() { }
    public Picture(Info info, int yearOfPremier, string photograph) : base(info, yearOfPremier)
    {
        this._photograph = photograph;
    }
    public override Multimedia Clone()
    {
        Info info = new Info(this._info.Length, this._info.Name, this._info.Description);
        Multimedia result = new Picture(info, this._yearOfPremier, this._photograph);
        return result;
    }

    public override string toString()
    {
        string result = String.Empty;
        result += _info.Name + "\n";
        result += _info.Description + "\n";
        result += _photograph + "\n";
        result += _info.Length.ToString() + "\n";
        result += _yearOfPremier.ToString() + "\n";
        return result;
    }
}

