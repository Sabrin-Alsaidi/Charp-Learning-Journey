namespace Day18;
class Program
{
    static void Main(string[] args)
    {
        #region Extention method
        ////Extention method
        //int x = 12345;
        //Console.WriteLine(x.Mirro());
        #endregion
        #region first step to linQ
        //List<int> lst = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //List<int> result = Enumerable.Where(lst,x => x % 2 ==0).ToList();

        //foreach (var x in result)
        //{
        //    Console.WriteLine(x);
        //}
        //Console.WriteLine(result.GetType());

        //List<int> oldResult = Enumerable.Where(lst, x => x% 2 != 0).ToList();
        //foreach(var y in oldResult)
        //{
        //    Console.WriteLine(y);
        //}
        //Console.WriteLine(oldResult.GetType());
        #endregion
        #region Deferred Execution

        List<int> lst = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // now it is Enumerable dataType but if we add .ToList() it will be a list dataType
        //Because it is Enumerable dataType when ever we make updates in the orginal list it(Enumerable) will be re-executed again to take the updates
        // but if we change the dataTupe to list than it will not be effected with the changes

        var number = lst.Where(i=> i%2==0); 
        Console.WriteLine(lst.GetType());
      
        Console.WriteLine("First:");
        foreach (int i in number)
        {
            Console.Write($" {i} ");
        }
        Console.WriteLine();
        //make updates
        lst.Remove(2);
        lst.AddRange(new int[] { 10, 11, 12, 13, 14 });

        Console.WriteLine("Second:");
        foreach (int i in number)
        {
            Console.Write($" {i} ");
        }
        lst.AddRange(new int[] { 15, 16, 17, 18, 19 });
        Console.WriteLine();

        Console.WriteLine("Thired:");
        foreach (int i in number)
        {
            Console.Write($" {i} ");
        }
        Console.WriteLine();
        #endregion
    }
}

