using System;

public interface IShapeWithSides
{
    public double GetDiagonal();
}
public abstract class Shape
{
    public abstract double GetArea();

    public abstract double GetCircumference();

    public virtual void Display()
    {
        Console.WriteLine($"Displaying result for some shape");
    }

}


public class Square : Shape, IShapeWithSides
{
    public Square(double side)
    {
        Side = side;
    }
    public double Side { get; set; }
    public override double GetArea() => Side * Side;

    public override double GetCircumference() => 4 * Side;

    public override void Display()
    {
        Console.WriteLine($"Displaying result for Square with side {Side}:");
        Console.WriteLine($"Area: {this.GetArea()} square unit:\n\t");
        Console.WriteLine($"Area: {this.GetCircumference()} square unit:\n\t");
    }
    public double GetDiagonal() => Math.Sqrt(2 * Side * Side);

}

public class Rectangle : Shape, IShapeWithSides
{
    public Rectangle(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }
    public double Length { get; set; }
    public double Breadth { get; set; }

    public override double GetArea() => Length * Breadth;

    public override double GetCircumference() => 2*(Length + Breadth);

    public double GetDiagonal() => Math.Sqrt(Length * Breadth);

}

public class Circle : Shape
{
      public Circle(double radious)
    {
      Radious = radious;
    }
    public double Radious { get; set; }

    public override double GetArea() => Math.PI * Radious * Radious;

    public override double GetCircumference() => 2* Math.PI * Radious;
}

class A 
{

}

class B : A
{
    
}

class C: B
{

}

class D : IA,IB
{
    
}

interface IA
{

}

interface IB 
{

}