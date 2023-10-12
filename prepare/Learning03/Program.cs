using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        string fraction1String = fraction1.GetFractionString();
        Console.WriteLine(fraction1String);
        string fraction2String = fraction2.GetFractionString();
        Console.WriteLine(fraction2String);
        string fraction3String = fraction3.GetFractionString();
        Console.WriteLine(fraction3String);

        double fraction1Decimal = fraction1.GetDecimalValue();
        Console.WriteLine(fraction1Decimal);
        double fraction2Decimal = fraction2.GetDecimalValue();
        Console.WriteLine(fraction2Decimal);
        double fraction3Decimal = fraction3.GetDecimalValue();
        Console.WriteLine(fraction3Decimal);



    }
}