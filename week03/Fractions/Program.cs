using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        string fractionString1 = fraction1.GetFractionString();
        Console.WriteLine(fractionString1);
        double decimalFraction1 = fraction1.GetDecimalValue();
        Console.WriteLine(decimalFraction1);
        
        Fraction fraction2 = new Fraction(5);
        string fractionString2 = fraction2.GetFractionString();
        Console.WriteLine(fractionString2);
        double decimalFraction2 = fraction2.GetDecimalValue();
        Console.WriteLine(decimalFraction2);

        Fraction fraction3 = new Fraction(3, 4);
        string fractionString3 = fraction3.GetFractionString();
        Console.WriteLine(fractionString3);
        double decimalFraction3 = fraction3.GetDecimalValue();
        Console.WriteLine(decimalFraction3);

        Fraction fraction4 = new Fraction(1,3);
        string fractionString4 = fraction4.GetFractionString();
        Console.WriteLine(fractionString4);
        double decimalFraction4 = fraction4.GetDecimalValue();
        Console.WriteLine(decimalFraction4);

    }
}