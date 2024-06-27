using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Movie : Multimedia
{
    private string _director = null!;
    public Movie() { }
    public Movie(Info info, int yearOfPremier, string director) : base(info, yearOfPremier)
    {
        this._director = director;
    }
    public override Multimedia Clone()
    {
        Info info = new Info(this._info.Length, this._info.Name, this._info.Description);
        Multimedia result = new Movie(info, this._yearOfPremier, this._director);
        return result;
    }

    public override string toString()
    {
        string result = String.Empty;
        result += _info.Name + "\n";
        result += _info.Description + "\n";
        result += _director + "\n";
        result += _info.Length.ToString() + "\n";
        result += _yearOfPremier.ToString() + "\n";

        return result;
    }
}

