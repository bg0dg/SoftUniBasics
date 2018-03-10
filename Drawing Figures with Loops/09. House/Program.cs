using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int stars = 1;

            if (n % 2 == 0)
            {
                stars = 2;
            }

            for (int r = 1; r <= (n + 1) / 2; r++)
            {                         
                    Console.WriteLine("{0}{1}{0}", new string('-', (n - stars) / 2), new string('*', stars));
                    stars += 2;
            }

            for (int r = 0; r <= n / 2 - 1; r++)
            {
                    Console.WriteLine("{0}{1}{0}", "|", new string('*', n - 2));
            }

        }
    }
}
