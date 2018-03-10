using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Java
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var width = 3 * n + 6;

            var height = 3 * n + 1;

            for (int r = 1; r <= n; r++)
            {
                Console.WriteLine("{0}~ ~ ~{1}",
            new string(' ', n), new string(' ', width + n + 5));

            }

            Console.WriteLine("{0}", new string('=', width - 1));

            if (n % 2 == 0)
            {
                for (int i = 1; i <= (height - (2 * n + 4)) / 2 + 1; i++)
                {
                    Console.WriteLine("|{0}|{1}|", new string('~', n * 2 + 4), new string(' ', n - 1));
                }
            }

            else
            {
                for (int i = 1; i <= (height - (2 * n + 4)) / 2 ; i++)
                {
                    Console.WriteLine("|{0}|{1}|", new string('~', n * 2 + 4), new string(' ', n - 1));
                }
            }

            Console.WriteLine("|{0}JAVA{0}|{1}|", new string('~', n), new string(' ', n - 1));

                for (int i = 1; i <= (height - (2 * n + 4)) / 2 ; i++)
                {
                    Console.WriteLine("|{0}|{1}|", new string('~', n * 2 + 4), new string(' ', n - 1));
                }

            Console.WriteLine("{0}", new string('=', width - 1));

            int counter = width - n - 2;

            for (int r = 0; r <= n - 1; r++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string(' ', r), new string('@', counter));
                counter -= 2;
            }

            Console.WriteLine("{0}", new string('=', width - n));
        }
    }
}
