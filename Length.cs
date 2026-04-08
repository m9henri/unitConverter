namespace unitConverter;

class Length {
    
    public static void Intro()
    {
        PublicVar Global = new();

        // Output
        Console.Clear();
        Console.WriteLine("What is your first unit?");
        Console.Write(
            "cm - centimeter\n" +
            "in - inch\n" +
            "ft - foot\n" +
            "m  - meter\n" +
            "yd - yard\n" +
            "km - kilometer\n" +
            "mi - mile\n\n" +
            ">> "
        );

        Global.Unit1 = Console.ReadLine();
        
        // checking if the user is smart
        if (String.IsNullOrEmpty(Global.Unit1)) { Environment.Exit(1); }

        Console.Write("You have the following options to convert into:\n\n");
        switch (Global.Unit1)
        {
            case "cm":
                Console.Write(
                    "in - inch"
                );
                break;
            case "in":
                Console.Write(
                    "cm - centimeter\n" +
                    "ft - foot"
                );
                break;
            case "ft":
                Console.Write(
                    "cm - centimeter\n" +
                    "in - inch\n" +
                    "m  - meter\n" +
                    "mi - mile"
                );
                break;
            case "m":
                Console.Write(
                    "ft - foot"
                );
                break;
            case "yd":
                Console.Write(
                    "ft - foot\n" +
                    "m  - meter"
                );
                break;
            case "km":
                Console.Write(
                    "mi - mile"
                );
                break;
            case "mi":
                Console.Write(
                    "ft - foot\n" +
                    "km - kilometer"
                );
                break;
            default:
                Environment.Exit(1);
                break;
        }
        Console.Write("\n\n>> ");

        Global.Unit2 = Console.ReadLine();
        if (String.IsNullOrEmpty(Global.Unit2)) { Environment.Exit(1); }

        Console.Write($"How many {Global.Unit1} do you wanna convert?\n\n>> ");
        Global.Amount = Convert.ToSingle(Console.ReadLine()); // not checking this like the other, maybe in future update

        Converter(Global.Unit1, Global.Unit2, Global.Amount);

        if (Global.Amount == 1)
        {
            Console.Write($"\n\n{Global.Amount} {Global.Unit1} is {Global.Result} {Global.Unit2}");
        } else
        {
            Console.Write($"\n\n{Global.Amount} {Global.Unit1} are {Global.Result} {Global.Unit2}");
        }

        Console.Write("\n\nPress any key to close the program. . . ");
        Console.ReadKey();
    }
    
    static double Converter(string unit1, string unit2, float amount) => (unit1, unit2) switch
        {
            ("cm", "in") => amount * 0.3937008,
            ("in", "cm") => amount * 2.54,
            ("in", "ft") => amount * 0.08333333,
            ("ft", "cm") => amount * 30.48,
            ("ft", "in") => amount * 12,
            ("ft", "m") => amount * 0.3048,
            ("ft", "mi") => amount * 0.0001893939,
            ("m", "ft") => amount * 3.28084,
            ("yd", "ft") => amount * 3,
            ("yd", "m") => amount * 0.9144,
            ("km", "mi") => amount * 0.6213712,
            ("mi", "ft") => amount * 5280,
            ("mi", "km") => amount * 1.609344
        };
}