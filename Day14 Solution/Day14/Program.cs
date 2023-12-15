namespace Day14;
class Program
{
    enum Months
    {
        Jan =1,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec
    }

    static void Main(string[] args)
    {
        #region enum
        //Months month = Months.Oct;
        //Console.WriteLine($"The month is {month} whis is {(int)month}");

        //string thisMonth = "Dec";

        ////Console.WriteLine((Enum.Parse(typeof(Months), thisMonth)));

        ////to get the numirac value after turning the string to enum
        //Console.WriteLine((int)(Enum.Parse(typeof(Months),thisMonth)));
        ////
        //if(Enum.TryParse(thisMonth,out Months mth)){
        //    Console.WriteLine(mth);
        //}
        ////to check if the string value is on the enum or not
        //if (Enum.IsDefined(typeof(Months), thisMonth))
        //{
        //    Console.WriteLine(Enum.Parse(typeof(Months),thisMonth));
        //}

        //foreach(Months mnth in Enum.GetValues(typeof(Months)))
        //{
        //    Console.WriteLine($"{mnth} : {(int)mnth}");
        //}
        #endregion
        user User1 = new user("Sabrin",27,700);
        user User2 = new user("Saba", 20, 150);



    }
}

