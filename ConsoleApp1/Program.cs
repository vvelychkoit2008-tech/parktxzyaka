using System;

abstract class Shape
{
    public abstract double GetArea();
    public abstract void PrintInfo();
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Фігура: Коло | Радіус = {Radius} | Площа = {GetArea():F2}");
    }
}
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Фігура: Прямокутник | Ширина = {Width}, Висота = {Height} | Площа = {GetArea():F2}");
    }
}

class Program
{
    static void Main()
    {
        Shape[] shapes = new Shape[]
        {
            new Circle(5),
            new Circle(2.3),
            new Rectangle(4, 6),
            new Rectangle(2.5, 3.8)
        };
        foreach (var shape in shapes)
        {
            shape.PrintInfo();
        }

        Console.ReadLine();
    }
}
