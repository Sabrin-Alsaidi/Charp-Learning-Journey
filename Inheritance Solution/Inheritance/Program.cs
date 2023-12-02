namespace Inheritance;
class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        Human human1 = new Human("Sabrin",false,27,false);
        Human human2 = new Human("Noor", true, 31, true);

        Employee emp = new Employee();
        Student student = new Student();
    }
}

