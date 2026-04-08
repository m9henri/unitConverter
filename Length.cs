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
        if (String.IsNullOrEmpty(Global.Unit1))
        {
            Environment.Exit(1);
        }

        switch (Global.Unit1)
        {
            case "cm":
                Console.Write(
                    "You have the following options to convert into:\n\n" +
                    "in - inch\n\n" +
                    ">> "
                );
                break;
            case "in":
                Console.Write(
                    "You have the following options to convert into:\n\n" +
                    "cm - centimeter\n" +
                    "ft - foot\n\n" +
                    ">> "
                );
                break;
            case "ft":
                Console.Write(
                    "You have the following options to convert into:\n\n" +
                    "cm - centimeter\n" +
                    "in - inch\n" +
                    "m  - meter\n" +
                    "mi - mile\n\n" +
                    ">> "
                );
                break;
            case "m":
                Console.Write(
                    "You have the following options to convert into:\n\n" +
                    "ft - foot\n\n" +
                    ">> "
                );
                break;
            case "yd":
                Console.Write(
                    "You have the following options to convert into:\n\n" +
                    "ft - foot\n" +
                    "m  - meter\n\n" +
                    ">> "
                );
                break;
            case "km":
                Console.Write(
                    "You have the following options to convert into:\n\n" +
                    "mi - mile\n\n" +
                    ">> "
                );
                break;
            case "mi":
                Console.Write(
                    "You have the following options to convert into:\n\n" +
                    "ft - foot\n" +
                    "km - kilometer\n\n" +
                    ">> "
                );
                break;
            default:
                Environment.Exit(1);
                break;
        }

        Global.Unit2 = Console.ReadLine(); // not checking this

        Console.Write($"How many {Global.Unit1} do you wanna convert?\n\n>> ");
        Global.Amount = Convert.ToSingle(Console.ReadLine()); // not checking this like the other, maybe in future update
        
        switch ((Global.Unit1, Global.Unit2))
        {
            case ("cm", "in"):
                Global.Result = CentimeterToInch(Global.Amount);
                break;
            case ("in", "cm"):
                Global.Result = InchToCentimeter(Global.Amount);
                break;
            case ("in", "ft"):
                Global.Result = InchToFoot(Global.Amount);
                break;
            case ("ft", "cm"):
                Global.Result = FootToCentimeter(Global.Amount);
                break;
            case ("ft", "in"):
                Global.Result = FootToInch(Global.Amount);
                break;
            case ("ft", "m"):
                Global.Result = FootToMeter(Global.Amount);
                break;
            case ("ft", "mi"):
                Global.Result = FootToMile(Global.Amount);
                break;
            case ("m", "ft"):
                Global.Result = MeterToFoot(Global.Amount);
                break;
            case ("yd", "ft"):
                Global.Result = YardToFoot(Global.Amount);
                break;
            case ("yd", "m"):
                Global.Result = YardToMeter(Global.Amount);
                break;
            case ("km", "mi"):
                Global.Result = KilometerToMile(Global.Amount);
                break;
            case ("mi", "ft"):
                Global.Result = MileToFoot(Global.Amount);
                break;
            case ("mi", "km"):
                Global.Result = MileToKilometer(Global.Amount);
                break;
        }

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

    static double CentimeterToInch(float input)
    {
        return input * 0.3937008;
    }
    static double InchToCentimeter(float input)
    {
        return input * 2.54;
    }
    static double InchToFoot(float input)
    {
        return input * 0.08333333;
    }
    static double FootToCentimeter(float input)
    {
        return input * 30.48;
    }
    static double FootToInch(float input)
    {
        return input * 12;
    }
    static double FootToMeter(float input)
    {
        return input * 0.3048;
    }
    static double FootToMile(float input)
    {
        return input * 0.0001893939;
    }
    static double MeterToFoot(float input)
    {
        return input * 3.28084;
    }
    static double YardToFoot(float input)
    {
        return input * 3;
    }
    static double YardToMeter(float input)
    {
        return input * 0.9144;
    }
    static double KilometerToMile(float input)
    {
        return input * 0.6213712;
    }
    static double MileToFoot(float input)
    {
        return input * 5280;
    }
    static double MileToKilometer(float input)
    {
        return input * 1.609344;
    }
}