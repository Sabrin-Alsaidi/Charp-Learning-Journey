namespace Dat5Activity;
class Program
{
    static void Main(string[] args)
    {
        #region convertion , Implicit - Explicit
        /*
        // Implicit
        int x = 10;
        long y = x;
        Console.WriteLine(y);

        Console.WriteLine("--------------------");

        //Explicit
        double w  = 19.5;
        int q = (int)w;
        Console.WriteLine(q);
        */
        #endregion

        #region Boxing - Un-Boxing Convertion
        /*
        //convert to string 
        int s = 1995;
        string year = Convert.ToString(s);
        Console.WriteLine($"This is a string value {year}");

        //parse
        int y = int.Parse(year);
        int age = 2023 - y;
        Console.WriteLine($"this is intager value {year}");
        Console.WriteLine($"My age is {age}");

        //TryParse
        string username = "sss123";
        int z;
        bool output = int.TryParse(username, out z);
        Console.WriteLine(output);
        String outputResult = int.TryParse(username, out z)?$"it can be convert" : "it cannot be converted";
        Console.WriteLine(outputResult);
        */

        #endregion

    }

}


        
