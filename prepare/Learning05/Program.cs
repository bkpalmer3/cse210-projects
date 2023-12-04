using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Square s = new Square("blue", 5);
        Rectangle r = new Rectangle("red", 4, 2);
        Circle c =new Circle("Green", 3);
        List<Shape> shapes = new List<Shape>()
        {
            s,r,c
        };
        
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.Getcolor());
            Console.WriteLine(shape.GetArea());
            Console.WriteLine();
        }

    }
}
