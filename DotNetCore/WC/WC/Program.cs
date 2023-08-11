// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;
using WC;

public class Program
{
    static void Main(string[] args)
    {
        string? fileName = null;
        string? input = null;
        string[] commandLine = new string[args.Count()];
        var counter = 0;

        foreach (string current in args)
        {
            if (current.Contains("."))
                fileName = current;
            else
            {
                commandLine[counter] = current;
                counter++;
            }
        }

        if (fileName == "")
        {
            Console.WriteLine("Enter your text");
            input = Console.ReadKey().ToString();
        }

        var wc = new WcImplementation();

        var result = wc.HandleArgs(fileName, input, commandLine);
        Console.WriteLine(result);
        //Pause for input, makes debugging easier
        Console.ReadKey();
    }
}