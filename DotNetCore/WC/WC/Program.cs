// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;
using WC;

public class Program
{
    static void Main(string[] args)
    {
        if (args[0] == "-c")
        {
            var wc = new WcImplementation();
            Console.WriteLine(wc.GetByteCount(args[1]));
        }
    }
}