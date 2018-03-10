using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sheriff
{
    class Program
    {
        static void Main(string[] args)
        {

            //first solution
            /*   int n = int.Parse(Console.ReadLine());

               if (n == 1)
               {
                   Console.WriteLine(".x.");
                   Console.WriteLine("/x\\");
                   Console.WriteLine("x|x");
                   Console.WriteLine("x|x");
                   Console.WriteLine("/x\\");
                   Console.WriteLine("\\x/");
                   Console.WriteLine("x|x");
                   Console.WriteLine("x|x");
                   Console.WriteLine("\\x/");
                   Console.WriteLine(".x.");

               }

               else
               {

               Console.WriteLine("{0}{1}x{1}{0}", new string('.', n), new string('.', (n - 1) / 2));
               Console.WriteLine("{0}{1}/x\\{1}{0}", new string('.', n), new string('.', (n - 3) / 2));
               Console.WriteLine("{0}{1}x|x{1}{0}", new string('.', n), new string('.', (n - 3) / 2));

               for (int r = (n - 1) / 2; r >= 0; r--)
               {
                   Console.WriteLine("{0}{1}|{1}{0}", new string('.', r), new string('x', (3 * n - 1) / 2 - r));            
               }

               for (int r = 1; r <= (n - 1) / 2; r++)
               {
                   Console.WriteLine("{0}{1}|{1}{0}", new string('.', r), new string('x', (3 * n - 1) / 2 - r));
               }

               Console.WriteLine("{0}{1}/x\\{1}{0}", new string('.', n), new string('.', (n - 3) / 2));
               Console.WriteLine("{0}{1}\\x/{1}{0}", new string('.', n), new string('.', (n - 3) / 2));

               for (int r = (n - 1) / 2; r >= 0; r--)
               {
                   Console.WriteLine("{0}{1}|{1}{0}", new string('.', r), new string('x', (3 * n - 1) / 2 - r));
               }

               for (int r = 1; r <= (n - 1) / 2; r++)
               {
                   Console.WriteLine("{0}{1}|{1}{0}", new string('.', r), new string('x', (3 * n - 1) / 2 - r));
               }

               Console.WriteLine("{0}{1}x|x{1}{0}", new string('.', n), new string('.', (n - 3) / 2));
               Console.WriteLine("{0}{1}\\x/{1}{0}", new string('.', n), new string('.', (n - 3) / 2));
               Console.WriteLine("{0}{1}x{1}{0}", new string('.', n), new string('.', (n - 1) / 2));
               }

              */

            //second solution
            

            int n = int.Parse(Console.ReadLine());

            int width = 3 * n;


            // First 3 lines
            Console.WriteLine("{0}x{0}",
                new string('.', (width - 1) / 2));
            Console.WriteLine("{0}/x\\{0}",
                new string('.', (width - 3) / 2));
            Console.WriteLine("{0}x|x{0}",
                new string('.', (width - 3) / 2));


            // Top
            int exesCount = n;
            int dotsCount = ((width - 1) - (2 * n)) / 2;

            for (int row = 1; row <= n / 2 + 1; row++)
            {
                Console.WriteLine("{0}{1}|{1}{0}",
                    new string('.', dotsCount),
                    new string('x', exesCount));

                dotsCount--;
                exesCount++;
            }

            dotsCount = 1;
            exesCount = (width - 3) / 2;
            for (int row = 1; row <= n / 2; row++)
            {
                Console.WriteLine("{0}{1}|{1}{0}",
                    new string('.', dotsCount),
                    new string('x', exesCount));

                dotsCount++;
                exesCount--;
            }

            // Midddle
            Console.WriteLine("{0}/x\\{0}",
                new string('.', (width - 3) / 2));
            Console.WriteLine("{0}\\x/{0}",
                new string('.', (width - 3) / 2));

            // Bottom
            exesCount = n;
            dotsCount = ((width - 1) - (2 * n)) / 2;

            for (int row = 1; row <= n / 2 + 1; row++)
            {
                Console.WriteLine("{0}{1}|{1}{0}",
                    new string('.', dotsCount),
                    new string('x', exesCount));

                dotsCount--;
                exesCount++;
            }

            dotsCount = 1;
            exesCount = (width - 3) / 2;
            for (int row = 1; row <= n / 2; row++)
            {
                Console.WriteLine("{0}{1}|{1}{0}",
                    new string('.', dotsCount),
                    new string('x', exesCount));

                dotsCount++;
                exesCount--;
            }

            // Last 3 lines
            Console.WriteLine("{0}x|x{0}",
                new string('.', (width - 3) / 2));
            Console.WriteLine("{0}\\x/{0}",
                new string('.', (width - 3) / 2));
            Console.WriteLine("{0}x{0}",
                new string('.', (width - 1) / 2));


        }
    }
}
