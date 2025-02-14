using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new("blue", 4);
        Console.WriteLine(square1.GetColor());
        Console.WriteLine(square1.GetArea());

        Rectangle rectangle1 = new("red", 7, 10);
        Console.WriteLine(rectangle1.GetArea());

        Circle circle = new("green", 15);
        Console.WriteLine(circle.GetArea());

        List<Shape> shapes = new();

        foreach(Shape s in shapes){
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}