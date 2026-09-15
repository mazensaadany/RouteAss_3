namespace RouteAss_3;

internal class Program
{

    public static string PrintWelcomeMessage()
    {
        return "Welcome to the library!";
    }

    public static void PrintBookTitle(string title)
    {
        Console.WriteLine($"book title: {title}");
    }

    public static int AddBonusPages(int pages)
    {
        return pages + 50;
    }

    public static void ApplyDiscount(double[] prices)
    {
        prices[0] -= 5.0;
    }

    public static int AddBonusPagesByRef(ref int pages)
    {
        pages += 50;
        return pages;
    }

    public static void ReplaceArray(ref double[] prices)
    {
        prices = new double[] { 10.0, 12.5, 15.0 };
    }

    public static bool TryGetPrice(string title, out double price)
    {
        if (title == "clean code")
        {
            price = 25.5;
            return true;
        }
        else
        {
            price = 0.0;
            return false;
        }
    }

    public static void PrintBookInfo(string title, int pages = 300)
    {
        Console.WriteLine($"Title: {title}, Pages: {pages}");
    }

    static void Main(string[] args)
    {
        #region 1st answer
        double[] prices = { 25.5, 40.0, 33.75 };

        Console.WriteLine(prices[1]);
        #endregion
        Console.WriteLine("---------------------------------");

        #region 2nd answer
        int[,] shelfCopies =
        {
        {3,5 },
        {1,4 },
        };

        Console.WriteLine(shelfCopies[1, 0]);
        #endregion
        Console.WriteLine("---------------------------------");

        #region 3rd answer

        Console.WriteLine(PrintWelcomeMessage());

        #endregion
        Console.WriteLine("---------------------------------");

        #region 4th answer

        PrintBookTitle("clean code");

        #endregion
        Console.WriteLine("---------------------------------");

        #region 5th answer
        Console.WriteLine($"pages number is: {AddBonusPages(400)}");
        // expected output: pages number is: 450,
        // bc we called it with parameter 400
        // and it adds 50 to it
        #endregion
        Console.WriteLine("---------------------------------");

        #region 6th answer
        prices = new double[] { 25.5, 40.0 };

        ApplyDiscount(prices);

        Console.WriteLine(prices[0]);

        // expected output: 20.5,
        // because we called ApplyDiscount with the prices array,
        #endregion
        Console.WriteLine("---------------------------------");

        #region 7th answer
        int pages = 400;
        AddBonusPagesByRef(ref pages);
        Console.WriteLine(pages);

        // expected output: 450,
        //but int pages is passed by reference to the method AddBonusPagesByRef,
        //so the original value of pages is modified to 450.
        #endregion
        Console.WriteLine("---------------------------------");

        #region 8th answer

        ReplaceArray(ref prices);
        Console.WriteLine(prices.Length);

        #endregion
        Console.WriteLine("---------------------------------");

        #region 9th answer
        TryGetPrice("clean code", out double price);
        Console.WriteLine($"price of book is: {price}");
        #endregion
        Console.WriteLine("---------------------------------");

        #region 10th answer
        PrintBookInfo("clean code");
        PrintBookInfo("clean code", 500);
        #endregion
        Console.WriteLine("---------------------------------");

        #region 11th answer
        
        #endregion
    }
}

