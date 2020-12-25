using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            while (str.Contains("  "))
            { 
                str = str.Replace("  ", " ");
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
