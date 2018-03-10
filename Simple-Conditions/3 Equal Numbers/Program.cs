using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Words
    {
        class Program
        {
            static void Main(string[] args)
            {
                string num1 = Console.ReadLine();
                string num2 = Console.ReadLine();
                string num3 = Console.ReadLine();

                if (num1 == num2 && num1 == num3)
                    Console.WriteLine("yes");
                else
                {
                    Console.WriteLine("no");
                }
            }
        }
    }

