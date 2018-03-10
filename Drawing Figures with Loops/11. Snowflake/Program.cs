using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int r = 0; r < n; r++)
            {
                if (n - r > 1) Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', r), new string('.', n - r));
                else Console.WriteLine("{0}*****{0}", new string('.', r));
            }

            Console.WriteLine(new string('*', 2 * n + 3));

            for (int r = n - 1; r >= 0; r--)
            {
                if (n - r > 1) Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', r), new string('.', n - r));
                else Console.WriteLine("{0}*****{0}", new string('.', r));
            }


        }
    }
}
