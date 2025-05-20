using System;

public class Converter
{
    public double FeetToInches(double feet)
    {
        return feet * 12;
    }
    public double YardsToInches(double Yards)
    {
        return Yards * 3*12;
    }
}
class Program
{
    public delegate double ConvertToInches(double value);
    static void Main()
    {
        Converter converter = new Converter();
        Console.WriteLine("輸入轉換的數值：");
        double input = double.Parse(Console.ReadLine());
        Console.WriteLine("輸入單位：feet或yards");
        string unit = Console.ReadLine().ToLower();

        ConvertToInches convertDelegate;
        if (unit == "feet")
        {
            convertDelegate = converter.FeetToInches;
        }
        else if (unit == "yards")
        {
            convertDelegate = converter.YardsToInches;
        }
        else
        {
            Console.WriteLine("單位無效，請輸入Feet 或 Yards");
            return;
        }
        double result=convertDelegate(input);
        Console.WriteLine($"結果: {result} 英吋");
        Console.ReadLine();

    }
}
