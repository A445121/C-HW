using System;

public class Math
{
    public int Cube(int x)
    {
        return x * x ;
    }
    public double Cube(double x)
    {
        return x * x ;
    }
    public int MinElement(int a, int b, int c)
    {
        int min = a;
        if (b < min) min = b;
        if (c < min) min = c;
        return min;
    }
    public int MinElement(int a, int b, int c, int d)
    {
        int min = a;
        if (b < min) min = b;
        if (c < min) min = c;
        if (d < min) min = d;
        return min;
    }
}

class Program
{
    static void Main()
    {
            Math Math = new Math();

            Console.Write("請輸入一個整數 算平方: ");
            int Val = int.Parse(Console.ReadLine());
            Console.WriteLine($"答案: {Math.Cube(Val)}");

            Console.Write("請輸入一個浮點數來 平方: ");
            double val = double.Parse(Console.ReadLine());
            Console.WriteLine($"答案: {Math.Cube(val)}");

            Console.WriteLine("請輸入三個整數 找最小值:");
            string[] inputs3 = Console.ReadLine().Split(' ');
            if (inputs3.Length != 3)
            {
                Console.WriteLine("錯誤：請輸入三個整數");
            }
            else
            {
                int a = int.Parse(inputs3[0]);
                int b = int.Parse(inputs3[1]);
                int c = int.Parse(inputs3[2]);
                Console.WriteLine($"三個數的最小值是: {Math.MinElement(a, b, c)}");
            }

            Console.WriteLine("請輸入四個整數 找最小值:");
            string[] inputs4 = Console.ReadLine().Split(' ');
            if (inputs4.Length != 4)
            {
                Console.WriteLine("錯誤：請輸入四個整數");
            }
            else
            {
                int a = int.Parse(inputs4[0]);
                int b = int.Parse(inputs4[1]);
                int c = int.Parse(inputs4[2]);
                int d = int.Parse(inputs4[3]);
            Console.WriteLine($"四個數的最小值是: {Math.MinElement(a, b, c)}");
            }

        Console.ReadLine();
        }
  }
