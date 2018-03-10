using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_of_N_x_N_Stars
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

                for (int r = 1; r <= n; r++)
                {

                for(var c = 1; c <= n; c++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

                }
        }
    }
}
