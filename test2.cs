using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectConsole_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int value = int.Parse(Console.ReadLine());

            if (value % 2 == 0)
            {
                Console.WriteLine(value + " is Even.");
            } else {
                Console.WriteLine(value + " is Odd.");
            }
        }
    }
}
