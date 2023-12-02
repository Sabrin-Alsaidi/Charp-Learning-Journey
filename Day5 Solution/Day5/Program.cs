namespace Day5;
class Program
{
    static void Main(string[] args)
    {
        /*//Type casting
        // implicit -- explicit
        //

        //Boxing -- unBoxing==> form value to refrance type
        int x = 10;
        string s = x.ToString();
        Console.WriteLine(s[0]);
       // s += 'a';

        bool flag = false;
        string sflag = flag.ToString();
        Console.WriteLine(sflag);

        // from refrance to value
        int z = int.Parse(s);
        //Console.WriteLine(z);

        bool revFlag = Convert.ToBoolean(sflag);
       // Console.WriteLine(z);
        Console.WriteLine(revFlag);
        
        string Value = "9999a";
        int x;
        bool res = int.TryParse(Value,out x);
        string result = int.TryParse(Value, out x)?$" Success Convertion {x}":"Fail Convertion";
        Console.WriteLine(x);
        Console.WriteLine(result);
        */

        int[] arr1 = { 1, 2, 3, 4, 5, 6 };
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.WriteLine(arr1[i]);
        }
        Console.WriteLine("--------------------");

        int ii = 0;
        while (ii < arr1.Length)
        {
            Console.WriteLine(arr1[ii]);
            ii++;
        }

    }
}

