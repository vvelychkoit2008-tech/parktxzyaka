using System;
class Shape
{
    public virtual double GetArea()
    {
        return 0;
    }
    public virtual void PrintInfo()
    {
        Console.WriteLine("Невідома фігура");
    }
}
class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(double r)
    {
        Radius = r;
    }
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
    public override void PrintInfo()
    {
        Console.WriteLine("Коло: Радіус = " + Radius + ", Площа = " + GetArea().ToString("F2"));
    }
}
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public Rectangle(double w, double h)
    {
        Width = w;
        Height = h;
    }
    public override double GetArea()
    {
        return Width * Height;
    }
    public override void PrintInfo()
    {
        Console.WriteLine("Прямокутник: Ширина = " + Width + ", Висота = " + Height + ", Площа = " + GetArea().ToString("F2"));
    }
}
class Program
{
    static void Main()
    {
        Shape[] shapes =
        {
            new Circle(5),
            new Circle(2.3),
            new Rectangle(4, 6),
            new Rectangle(2.5, 3.8)
        };
        foreach (var s in shapes)
        {
            s.PrintInfo();
        }
    }
}
