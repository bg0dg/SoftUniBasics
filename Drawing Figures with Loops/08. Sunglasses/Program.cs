﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('*', 2 * n), new string(' ', n));

            for (int r = 0; r < n - 2; r++)
            {
                if (r == (n - 1) / 2 - 1)
                {
                    
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", new string('*', 1), new string('/', 2 * n - 2), new string('|', n));
                }
                else
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", new string('*', 1), new string('/', 2 * n - 2), new string(' ', n));
            }

            Console.WriteLine("{0}{1}{0}", new string('*', 2 * n), new string(' ', n));
            
        }
    }
}
