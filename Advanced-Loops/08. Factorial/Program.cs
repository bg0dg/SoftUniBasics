using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Numbers_N_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            int result = 1;

            for (int i = 1; i <= num; i++)
            {
                result = result * i;
            }

                Console.WriteLine(result);
        }
    }
}
