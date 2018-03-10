using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int r = 1; r <= n; r++)
            {
                string changeChar = "| ";
                if (r == 1 || r == n) changeChar = "+ ";

                Console.Write(changeChar);
                for (int c = 1; c <= n-2; c++) Console.Write("- ");
                Console.WriteLine(changeChar);
            }
            
        }
    }
}
