using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            //comment

            Console.WriteLine("Input number greater than 2:");
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine(new string('*', n));
                }
                if (i > 1 && i<n)
                {
                    Console.Write(new string('*', 1));
                    Console.Write(new string(' ', n-2));
                    Console.WriteLine(new string('*', 1));
                }

                if (i == n)
                {
                    Console.WriteLine(new string('*', n));
                }
            }
        }
    }
}
