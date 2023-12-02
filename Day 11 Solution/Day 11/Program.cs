namespace Day_11;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        // Console.WriteLine("Enter your name :");
        // string name = Console.ReadLine();
        // Console.WriteLine("Enter your age :");
        // string sage;
        // int age;
        // do
        // {
        //     sage = Console.ReadLine();
        // } while (!int.TryParse(sage, out age)&& Human.ageValidation(age));

        //// int age = int.Parse();

        // Console.WriteLine("Enter your address : ");
        // string address = Console.ReadLine();
        // Console.WriteLine("Enter your email :");
        // string email = Console.ReadLine();

        Human human1= new Human("Sabrin",27,"sssss","sssss@gmail.com");
        Human human2 = new Human("Saba", 19, "wwwwww", "wwwww@gmail.com");
        // Console.WriteLine("-----------------------------");
        // Console.WriteLine(human.PrintData());

        Console.WriteLine(human1.getId());
        Console.WriteLine(human1.getEgmail());
        human1.setEmail("xxxxxx@gmail.com");
        Console.WriteLine(human1.getEgmail());
        Console.WriteLine(human2.getId());
        Console.WriteLine(human2.getEgmail());
        human2.setEmail("yyyyyyyy@gmail.com");
        Console.WriteLine(human2.getEgmail());
    }
}

