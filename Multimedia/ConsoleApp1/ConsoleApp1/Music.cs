using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Music : Multimedia
{
    private string _singer = null!;
    public Music() { }
    public Music(Info info, int yearOfPremier,string _singer) : base(info, yearOfPremier)
    {
        this._singer = _singer;
    }
    public override Multimedia Clone()
    {
        Info info = new Info(this._info.Length, this._info.Name, this._info.Description);
        Multimedia result = new Music(info, this._yearOfPremier, this._singer);
        return result;
    }

    public override string toString()
    {
        string result = String.Empty;
        result += _info.Name + "\n";
        result += _info.Description + "\n";
        result += _singer + "\n";
        result += _info.Length.ToString() + "\n";
        result += _yearOfPremier.ToString() + "\n";
        return result;
    }
}

