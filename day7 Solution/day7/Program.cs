namespace day7;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //int result;
        //int[] numbers = {1,2,3,4,5};
        // colculate(int x , int y , int[] num);
        int x = 1;
        //int sum = 0;
        int sum = colculate(out x , 1,2,3,4,5);
        Console.WriteLine($"the sum is {sum} and the ");


    }

    static int colculate(out int a,params int[] arr)
    {
        a = 1;
        int sum = 0;
        for(int i=0; i < arr.Length; i++)
        {
            if (arr.Length < 1)
            {

                a = arr[i] * a;
            }
            else
            {
                sum = +arr[i];
            }
           
        }
        return sum;
        
    }
}

