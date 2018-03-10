using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {

                Console.Clear();

                Console.Write("Enter an integer number - dividend: ");
                uint dividend = uint.Parse(Console.ReadLine());

                Console.Write("Enter an integer number - divisor : ");
                uint divisor = uint.Parse(Console.ReadLine());

                uint result = dividend % divisor;

                Console.Clear();

                Console.Write(dividend + " % " + divisor + " = " + result);

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }
    }
}
