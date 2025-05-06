using System;

public class PhoneList
{
    public string HomePhone { get; set; }
    public string BusinessPhone { get; set; }
    public string CellPhone { get; set; }

    public PhoneList(string homePhone, string businessPhone, string cellPhone)
    {
        HomePhone = homePhone;
        BusinessPhone = businessPhone;
        CellPhone = cellPhone;
    }
}

public class Cards
{
    public string Name { get; set; }
    public string Occupation { get; set; }
    public int Age { get; set; }
    public PhoneList Phone { get; set; }
    public string Email { get; set; }

    public Cards(string name, string occupation, int age, PhoneList phone, string email)
    {
        Name = name;
        Occupation = occupation;
        Age = age;
        Phone = phone;
        Email = email;
    }

    public string GetCard()
    {
        return $"--- 名片資料 ---\n" +
               $"姓名：{Name}\n" +
               $"職業：{Occupation}\n" +
               $"年齡：{Age}\n" +
               $"住家電話：{Phone.HomePhone}\n" +
               $"公司電話：{Phone.BusinessPhone}\n" +
               $"手機電話：{Phone.CellPhone}\n" +
               $"電子郵件：{Email}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("請輸入姓名：");
        string name = Console.ReadLine();
        Console.Write("請輸入職業：");
        string occupation = Console.ReadLine();
        Console.Write("請輸入年齡：");
        int age = int.Parse(Console.ReadLine());

        Console.Write("請輸入住家電話（9或10碼）：");
        string homePhone = Console.ReadLine();
        while (homePhone.Length != 9 && homePhone.Length != 10)
        {
            Console.WriteLine("住家電話格式錯誤，請重新輸入！");
            homePhone = Console.ReadLine();
        }
        Console.Write("請輸入公司電話（9或10碼）：");
        string businessPhone = Console.ReadLine();
        while (businessPhone.Length != 9 && businessPhone.Length != 10)
        {
            Console.WriteLine("公司電話格式錯誤，請重新輸入！");
            businessPhone = Console.ReadLine();
        }
        Console.Write("請輸入手機電話（10碼）：");
        string cellPhone = Console.ReadLine();
        while (cellPhone.Length != 10)
        {
            Console.WriteLine("手機電話格式錯誤，請重新輸入！");
            cellPhone = Console.ReadLine();
        }
        Console.Write("請輸入電子郵件：");
        string email = Console.ReadLine();

        PhoneList phone = new PhoneList(homePhone, businessPhone, cellPhone);
        Cards card = new Cards(name, occupation, age, phone, email);
        Console.WriteLine("\n" + card.GetCard());
    }
}
