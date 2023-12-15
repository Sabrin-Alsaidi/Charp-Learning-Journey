namespace Day13;
class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee(1,"Sabrin",27,12345,"Muscat","developer",8,3.2);
        Console.WriteLine(emp); // by defualt it is to string method
        emp.talk();
    }
    
}

