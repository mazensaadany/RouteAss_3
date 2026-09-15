namespace RouteAss_3;

internal class Program
{

    public static string PrintWelcomeMessage()
    {
        return "Welcome to the library!";
    }

    public static void PrintBookTitle(string title)
    {
        Console.WriteLine($" book title: {title}");
    }

    public static int AddBonusPages(int pages)
    {
        return pages + 50;
    }

    public static void ApplyDiscount(double[] prices)
    {
        prices[0] -= 5.0;
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
    }
}

