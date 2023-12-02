namespace DayThree
{
    class program
    {
        static void Main()
        {
            int x = 3;
            //Ternary operator 
            string result = (x % 2 == 0 ) ? " X is even number " : "X is odd number ";
            Console.WriteLine(result);


            int number = 15;
            Console.WriteLine((number % 3 == 0) ? "The number is divisable by 3 " : " The number is not divisable by 3 ");
        }
    }
}