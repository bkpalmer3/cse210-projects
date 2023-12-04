using System.Drawing;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;

public class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public string Getcolor()
    {
        return _color;
    }

    public virtual double GetArea()
    {
        double area = 0;
        return area;
    }

}