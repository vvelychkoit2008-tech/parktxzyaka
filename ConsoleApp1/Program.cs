using System;

abstract class Shape //клас не можна створити напряму
{
    public abstract double GetArea(); //метод для обчислення площі
    public abstract void PrintInfo(); //виведення інфо про фігуру
}
class Circle : Shape
{
    public double Radius { get; set; } //radius - властивість кола

    public Circle(double radius) //дозволяє створювати об’єкт із заданим радіусом
    {
        Radius = radius;
    }

    public override double GetArea() //обчислює площу
    {
        return Math.PI * Radius * Radius;
    }

    public override void PrintInfo() //виводить інформацію про коло
    {
        Console.WriteLine($"Фігура: Коло | Радіус = {Radius} | Площа = {GetArea():F2}");
    }
}
class Rectangle : Shape
{
    public double Width { get; set; } //ширина
    public double Height { get; set; } //висота

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
        Shape[] shapes = new Shape[] //масив
        {
            new Circle(5),
            new Circle(2.3),
            new Rectangle(4, 6),
            new Rectangle(2.5, 3.8)
        };
        foreach (var shape in shapes) // викликається метод PrintInfo для кожної фігури
        /*
         *Поліморфізм: хоча тип змінної shape – Shape, 
         *виконується саме той метод, який відповідає 
         *реальному типу об’єкта (Circle або Rectangle).
        */
        {
            shape.PrintInfo();
        }

        Console.ReadLine();
    }
}
