using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickOnceOnGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String to print:)");
            Console.WriteLine($"{Console.ReadLine()}{Environment.NewLine}Press any key to exit.");
            Console.ReadKey();
        }
    }
}
