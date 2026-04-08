namespace unitConverter;

struct PublicVar
{
    public string? Unit1 { get; set; }
    public string? Unit2 { get; set; }
    public float Amount { get; set; }
    public double Result { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        string[] units = ["Length", "Mass (still unsupported)", "Time (still unsupported)"];
        string input;

        Console.WriteLine("What unit class do you want to convert in?\n");
        for (int i = 0; i < units.Length; i++)
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(i+1);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"] {units[i]}\n");

        }
        Console.Write("\n>> ");
        input = Convert.ToString(Console.ReadKey().KeyChar);
        
        switch (input)
        {
            case "1":
                Length.Intro();
                break;
            default:
                Console.WriteLine("Fuck you and microslop for making the compiler inside vscode for c# proprietary and not making it work on linux"); // some pent up anger
                Environment.Exit(80085);
                break;
        }
    }
}
