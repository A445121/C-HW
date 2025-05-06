using System;

public class Box
{
    private double width;
    private double height;
    private double length;
    public Box(double width, double height, double length)
    {
        this.width = width;
        this.height = height;
        this.length = length;
    }
    public double Volume()
    {
        return width * height * length;
    }
    public double Area()
    {
        return 6 * (width * height);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("請輸入長度：");
        double length = double.Parse(Console.ReadLine());
        Console.Write("請輸入寬度：");
        double width = double.Parse(Console.ReadLine());
        Console.Write("請輸入高度：");
        double height = double.Parse(Console.ReadLine());
        Box Box = new Box(width, height, length);

        Console.WriteLine($"體積：{Box.Volume()}");
        Console.WriteLine($"表面積：{Box.Area()}");
    }
}
