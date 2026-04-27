namespace unitConverter;

class Time
{
    public static void Intro()
    {
        PublicVar Global = new();

        // Output
        Console.Clear();
        Console.Write(
            "What is your first unit?\n" +
            "ms - milliseconds\n" +
            "s  - seconds\n" +
            "mn - minutes\n" +
            "hr - hours\n" +
            "d  - days\n" +
            "wk - weeks\n" +
            "mo - month (30 days)\n" +
            "yr - year (365,25 days)\n\n" +
            ">> "
        );

        Global.Unit1 = Console.ReadLine();
        
        // checking if the user is smart
        if (String.IsNullOrEmpty(Global.Unit1)) { Environment.Exit(1); }

        Console.Write("What is your second unit?\n>> ");

        Global.Unit2 = Console.ReadLine();
        if (String.IsNullOrEmpty(Global.Unit2)) { Environment.Exit(1); }

        Console.Write($"How many {Global.Unit1} do you wanna convert?\n\n>> ");
        Global.Amount = Convert.ToSingle(Console.ReadLine()); // not checking this like the other, maybe in future update

        while (Global.Amount < 0)
        {
            Console.Write("You entered an invalid value. Please enter a new one.\n>> ");
            Global.Amount = Convert.ToSingle(Console.ReadLine());
        }

        Global.Result = Converter(Global.Unit1, Global.Unit2, Global.Amount);

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

    static double Converter(string unit1, string unit2, float amount) => (unit1, unit2) switch
    {
        ("ms", "s") => amount * 0.001,
        ("ms", "mn") => amount * 0.00001666667,
        ("ms", "hr") => amount * 0.0000002777778,
        ("ms", "d") => amount * 0.000000011574074074074074074,
        ("ms", "wk") => amount * 0.000000001653439534395343953439534395,
        ("ms", "mo") => amount * 0.0000000003858024691358025,
        ("ms", "yr") => amount * 0.00000000003168808781402895,
        ("s", "ms") => amount * 1000,
        ("s", "mn") => amount * 0.01666667,
        ("s", "hr") => amount * 0.0002777778,
        ("s", "d") => amount * 0.000011574074074074074074,
        ("s", "wk") => amount * 0.000001653439534395343953439534395,
        ("s", "mo") => amount * 0.0000003858024691358025,
        ("s", "yr") => amount * 0.00000003168808781402895,
        ("mn", "ms") => amount * 60000,
        ("mn", "s") => amount * 60,
        ("mn", "hr") => amount * 0.01666667,
        ("mn", "d") => amount * 0.00069444444,
        ("mn", "wk") => amount * 0.000099206349206349206349206349206349,
        ("mn", "mo") => amount * 0.000023148148,
        ("mn", "yr") => amount * 0.000001901285256673511,
        ("hr", "ms") => amount * 3600000,
        ("hr", "s") => amount * 3600,
        ("hr", "mn") => amount * 60,
        ("hr", "d") => amount * 0.041666667,
        ("hr", "wk") => amount * 0.0059523809523809525238095252380952523809525,
        ("hr", "mo") => amount * 0.0013888889,
        ("hr", "yr") => amount * 0.0001140771170431211,
        ("d", "ms") => amount * 86400000,
        ("d", "s") => amount * 86400,
        ("d", "mn") => amount * 1440,
        ("d", "hr") => amount * 24,
        ("d", "wk") => amount * 0.1428571428571428571428571428571,
        ("d", "mo") => amount * 0.03333333333333333,
        ("d", "yr") => amount * 0.002737850787132101,
        ("wk", "ms") => amount * 604800000,
        ("wk", "s") => amount * 604800,
        ("wk", "mn") => amount * 10080,
        ("wk", "hr") => amount * 168,
        ("wk", "d") => amount * 7,
        ("wk", "mo") => amount * 0.2333333333333333,
        ("wk", "yr") => amount * 0.01916495550992471,
        ("mo", "ms") => amount * 2592000000,
        ("mo", "s") => amount * 2592000,
        ("mo", "mn") => amount * 43200,
        ("mo", "hr") => amount * 720,
        ("mo", "d") => amount * 30,
        ("mo", "wk") => amount * 4.285714285714286,
        ("mo", "yr") => amount * 0.08213552361396304,
        ("yr", "ms") => amount * 31557600000,
        ("yr", "s") => amount * 31557600,
        ("yr", "mn") => amount * 525960,
        ("yr", "hr") => amount * 8766,
        ("yr", "d") => amount * 365.25,
        ("yr", "wk") => amount * 52.17857142857143,
        ("yr", "mo") => amount * 12
    };
}
