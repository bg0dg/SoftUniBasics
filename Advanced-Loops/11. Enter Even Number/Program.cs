using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Number_in_Range_1_to_100
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;

            while (true)
            {               
                Console.Write("Enter even number: ");

                try
                {
                    n = int.Parse(Console.ReadLine());

                    if (n % 2 == 0)
                    {
                        break;
                    }

                    Console.WriteLine("Invalid number!");
                }

                catch (FormatException)
                {
                    Console.WriteLine("Invalid number!");
                }
                
            }

            Console.WriteLine("Even number entered: " + n);
        }
    }
}
