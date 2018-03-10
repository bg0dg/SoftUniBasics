using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_of_Stars_combined
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input number between 2 and 100: ");
            int n = int.Parse(Console.ReadLine());

            string starsLine = new string('*', n);
            string middleLine = new string(' ', n - 2);

            Console.WriteLine(starsLine);
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write('*');
                Console.Write(middleLine);
                Console.WriteLine('*');       
            }
            Console.WriteLine(starsLine);           

        }
    }
}
