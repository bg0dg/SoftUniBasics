using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int r = 0; r <= n; r++)
            {
                Console.WriteLine("{0}{1} | {1}{0}", new string(' ', n - r), new string('*', r));
            }
        }
    }
}
