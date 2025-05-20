using System;
public interface IPrice
{
    double GetPrice();
}

public class Car : IPrice
{
   public double Price { get; set; }
    public string Name { get; set; }

    public Car(string name,double price)
    {
        Name = name;
        Price = price;
    }

    public double GetPrice()
    {
        return Price;
    }
    public string GetName()
    {
        return Name;
    }
  
}
class Program
{
    static void Main()
    {
        Console.WriteLine("請輸入車名");
        string name = Console.ReadLine();
        Console.WriteLine("請輸入價格");
        string inputprice = Console.ReadLine();
        double price;

        while (!double.TryParse(inputprice, out price))
        {
            Console.Write("價格輸入錯誤，請重新輸入: ");
            inputprice = Console.ReadLine();
        }

        Car Car = new Car(name, price);
        Console.WriteLine("車輛資訊");
        Console.WriteLine("車名: " + Car.GetName());
        Console.WriteLine("價格: " + Car.GetPrice());
    }
}