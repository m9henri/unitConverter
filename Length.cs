namespace unitConverter;

class Length {
    
    public static void Intro()
    {
        PublicVar Global = new();

        // Output
        Console.Clear();
        Console.Write(
            "What is your first unit?\n" +
            "cm - centimeter\n" +
            "in - inch\n" +
            "ft - foot\n" +
            "yd - yard\n" +
            "m  - meter\n" +
            "km - kilometer\n" +
            "mi - mile\n\n" +
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
            ("cm", "in") => amount * 0.3937008,
            ("cm", "ft") => amount * 0.0328084,
            ("cm", "yd") => amount * 0.01093613,
            ("cm", "m") => amount * 0.01,
            ("cm", "km") => amount * 0.00001,
            ("cm", "mi") => amount * 0.000006213712,
            ("in", "cm") => amount * 2.54,
            ("in", "ft") => amount * 0.08333333,
            ("in", "yd") => amount * 0.02777778,
            ("in", "m") => amount * 0.0254,
            ("in", "km") => amount * 0.0000254,
            ("in", "mi") => amount * 0.00001578283,
            ("ft", "cm") => amount * 30.48,
            ("ft", "in") => amount * 12,
            ("ft", "yd") => amount * 0.333333333333,
            ("ft", "m") => amount * 0.3048,
            ("ft", "km") => amount * 0.0003048,
            ("ft", "mi") => amount * 0.0001893939,
            ("yd", "cm") => amount * 91.44,
            ("yd", "in") => amount * 36,
            ("yd", "ft") => amount * 3,
            ("yd", "m") => amount * 0.9144,
            ("yd", "km") => amount * 0.0009144,
            ("yd", "mi") => amount * 0.000568181811,
            ("m", "cm") => amount * 100,
            ("m", "in") => amount * 39.37008,
            ("m", "ft") => amount * 3.28084,
            ("m", "yd") => amount * 1.093613,
            ("m", "km") => amount * 0.001,
            ("m", "mi") => amount * 0.0006213712,
            ("km", "cm") => amount * 100000,
            ("km", "in") => amount * 39370.08,
            ("km", "ft") => amount * 3280.84,
            ("km", "yd") => amount * 1093.613,
            ("km", "m") => amount * 1000,
            ("km", "mi") => amount * 0.6213712,
            ("mi", "cm") => amount * 160934.4,
            ("mi", "in") => amount * 63360,
            ("mi", "ft") => amount * 5280,
            ("mi", "yd") => amount * 1760,
            ("mi", "m") => amount * 1609.344,
            ("mi", "km") => amount * 1.609344
        };
}