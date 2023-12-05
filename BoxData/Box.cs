using System;
using System.Text;

namespace BoxData;

public class Box
{
    private double _leinght;
    private double _width;
    private double _height;
    public Box(double leinght,double width, double height)
    {
        _leinght = leinght;
        _width = width;
        _height = height;
    }

    public double Leinght 
    {
        get {return _leinght;}
        set 
        {_leinght = value;}
    }
    public double Width
    {
        get { return _width;}
        set {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            _width = value;
        }

    }
    public double Height
    {
        get { return _height;}
        set {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
            _height = value;
        }
      
    } 
    public double SurfaceArea() 
    {
        return 2*this.Leinght*this.Width+2* this.Leinght* this.Height+2*this.Width* this.Height;
    }
    public double Volume()
    {
       return this.Leinght * this.Height * this.Width ;
    }

    public override string ToString()
    {
        return $"Surface Area – {SurfaceArea():F2}\nVolume – {Volume():F2}";
    }
}
