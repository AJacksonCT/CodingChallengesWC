// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;
using WC;

public class Program
{
    static void Main(string[] args)
    {
        var wc = new WcImplementation();

        switch (args[0].ToLower())
        {
            case "-c":
            {

                Console.WriteLine(wc.GetByteCount(args[1]));
                break;
            }
            case "-l":
            {
                Console.WriteLine(wc.GetLineCount(args[1]));
                break;
            }
            case "-w":
            {
                Console.WriteLine(wc.GetWordCountFromFile(args[1]));
                break;
            }
            case "-m":
            {
                Console.WriteLine(wc.GetCharacterCountFromFile(args[1]));
                break;
            }
            default:
            {
                Console.WriteLine("Invalid parameters");
                break;
            }
        }

        //Pause for input, makes debugging easier
        Console.ReadKey();
    }
}