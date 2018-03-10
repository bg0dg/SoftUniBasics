using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10. Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

                var minusLR = (n - 2) / 2;
                var minusMid = n - 2 * minusLR - 2;

            if (n == 1) Console.WriteLine('*');

            else
            {
                for (int r = 0; r < n / 2; r++)
                {

                    if (n % 2 != 0 && r == 0)
                    {
                        Console.WriteLine("{0}{1}{0}", new string('-', (n - 1) / 2), new string('*', 1));
                    }
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', minusLR - r), new string('*', 1), new string('-', minusMid + 2 * r));
                }

                if (n == 3)
                {
                    Console.WriteLine("{0}{1}{0}", new string('-', (n - 1) / 2), new string('*', 1));
                }
                else
                {
                    for (int r = (n / 2) - 2; r >= 0; r--)
                    {
                        Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', minusLR - r), new string('*', 1), new string('-', minusMid + 2 * r));

                        if (n % 2 != 0 && r == 0)
                        {
                            Console.WriteLine("{0}{1}{0}", new string('-', (n - 1) / 2), new string('*', 1));
                        }

                    }
                }
            }          
        }
    }
}
