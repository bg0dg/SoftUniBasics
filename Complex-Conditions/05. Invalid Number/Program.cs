using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number [100 ... 200]: ");

            int num = int.Parse(Console.ReadLine());

            if ((num < 100 || num > 200) && num != 0)
                Console.WriteLine("invalid");
        }
    }
}
