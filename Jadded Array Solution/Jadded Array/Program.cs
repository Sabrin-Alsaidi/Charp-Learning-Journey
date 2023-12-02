namespace Jadded_Array;
class Program
{
    static void Main()
    {
        #region array
        /* int[][] jagged_arr = new int[4][];
         jagged_arr[0] = new int[] { 1, 2, 3, 4 };
         jagged_arr[1] = new int[] { 1, 2,3};
         jagged_arr[2] = new int[] { 1, 2 };
         jagged_arr[3] = new int[] { 1, 2, 3, 4, 5 };
         int num = jagged_arr[0][3];
         Console.WriteLine($"The theird element of the first array is : {num}" );

        int[] number = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] slice = number[0..^5];
        for (int x = 0; x < slice.Length;x++)

        {
            Console.WriteLine(slice[x]);
        }
       // Console.WriteLine($" Numbers are :{slice[3]}");
        */
        #endregion

        #region convertion , Implicit - Explicit
        // Implicit
        int x = 10;
        long y = x;
        Console.WriteLine(y);

        #endregion 
    }
}

