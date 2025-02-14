using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new("blue", 4);
        square1.GetColor();
        square1.GetArea();

        Rectangle rectangle1 = new("red", 7, 10);
        rectangle1.GetArea();

        Circle circle = new("green", 15);
        circle.GetArea();

        List<Shape> shapes = new();
    }
}