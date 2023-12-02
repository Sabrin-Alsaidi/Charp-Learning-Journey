namespace Day12;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        PhoneBook MyPhone = new PhoneBook(5);
        MyPhone.AddPhone("Sabrin", 9811111111);
        MyPhone.AddPhone("Abdullah", 982222222);
        MyPhone.AddPhone("Salma", 983333333);
        MyPhone.GetAll();

        Console.WriteLine("---------");
        Console.WriteLine("Enter name :");
        string xname = Console.ReadLine();
        Console.WriteLine($"Your number is : {MyPhone.GetNumber(xname)}");
        Console.WriteLine("---------------------");
        MyPhone.EditNumber("Salma", 123456789);
        Console.WriteLine("---------------------");
        //this is geting the number of Abdullah throw the indexer get
        Console.WriteLine($"Get Abdullah phone number is : {MyPhone["Abdullah"]}");
        Console.WriteLine("------------------------");
        MyPhone["JK"] = 123456789;//new record
        MyPhone["Salma"] = 0987654321;//updating in old record
        MyPhone.GetAll();

    }
}

