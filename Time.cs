namespace unitConverter;

class Time
{
    public static void Intro()
    {
        PublicVar Global = new();
        bool includeMonth = false;
        bool includeYear = false;

        // Output
        Console.Clear();
        Console.Write(
            "What is your first unit?\n" +
            "ms - milliseconds\n" +
            "s  - seconds\n" +
            "mn - minutes\n" +
            "hr - hours\n" +
            "d  - days\n" +
            "wk - weeks\n\n" +
            ">> "
        );

        Global.Unit1 = Console.ReadLine();
        
        // checking if the user is smart
        if (String.IsNullOrEmpty(Global.Unit1)) { Environment.Exit(1); }

        Console.Write("What is your second unit?\n>> ");

        Global.Unit2 = Console.ReadLine();
        if (String.IsNullOrEmpty(Global.Unit2)) { Environment.Exit(1); }

        // special rules for time
        if (Global.Unit1 == "mo" || Global.Unit2 == "mo") { includeMonth = true; }
        if (Global.Unit1 == "yr" || Global.Unit2 == "yr") { includeYear = true; }

        Console.Write($"How many {Global.Unit1} do you wanna convert?\n\n>> ");
        Global.Amount = Convert.ToSingle(Console.ReadLine()); // not checking this like the other, maybe in future update

        while (Global.Amount < 0)
        {
            Console.Write("You entered an invalid value. Please enter a new one.\n>> ");
            Global.Amount = Convert.ToSingle(Console.ReadLine());
        }

        Global.Result = Converter(Global.Unit1, Global.Unit2, Global.Amount, includeMonth, includeYear);

        if (Global.Amount == 1)
        {
            Console.Write($"\n\n{Global.Amount} {Global.Unit1} is {String.Format("{0:0.00}", Global.Result)} {Global.Unit2}");
        } else
        {
            Console.Write($"\n\n{Global.Amount} {Global.Unit1} are {String.Format("{0:0.00}", Global.Result)} {Global.Unit2}");
        }

        Console.Write("\n\nPress any key to close the program. . . ");
        Console.ReadKey();
    }

    static double Converter(string unit1, string unit2, float amount, bool includeMonth, bool includeYear)
    {
        double modifier = 0;
        // if block for month and year
        
        modifier = (unit1, unit2) switch
        {
            ("ms", "s") => 0.001,
            ("ms", "mn") => 0.00001666667,
            ("ms", "hr") => 0.0000002777778,
            ("ms", "d") => 0.000000011574074074074074074,
            ("ms", "wk") => 0.000000001653439534395343953439534395,
            ("s", "ms") => 1000,
            ("s", "mn") => 0.01666667,
            ("s", "hr") => 0.0002777778,
            ("s", "d") => 0.000011574074074074074074,
            ("s", "wk") => 0.000001653439534395343953439534395,
            ("mn", "ms") => 60000,
            ("mn", "s") => 60,
            ("mn", "hr") => 0.01666667,
            ("mn", "d") => 0.00069444444,
            ("mn", "wk") => 0.000099206349206349206349206349206349,
            ("hr", "ms") => 3600000,
            ("hr", "s") => 3600,
            ("hr", "mn") => 60,
            ("hr", "d") => 0.041666667,
            ("hr", "wk") => 0.0059523809523809525238095252380952523809525,
            ("d", "ms") => 86400000,
            ("d", "s") => 86400,
            ("d", "mn") => 1440,
            ("d", "hr") => 24,
            ("d", "wk") => 0.1428571428571428571428571428571,
            ("wk", "ms") => 604800000,
            ("wk", "s") => 604800,
            ("wk", "mn") => 10080,
            ("wk", "hr") => 168,
            ("wk", "d") => 7
        };
        
        // failsafe
        if (modifier == 0) { Environment.Exit(1); }
        return amount * modifier;
    }
}