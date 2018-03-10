using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int pcsOneBGN = int.Parse(Console.ReadLine());
            int pcsTwoBGN = int.Parse(Console.ReadLine());
            int pcsFiveBGN = int.Parse(Console.ReadLine());
            int sumBGN = int.Parse(Console.ReadLine());

            for(int one = 0; one <= pcsOneBGN; one++)
            {
                for (int two = 0; two <= pcsTwoBGN; two++)
                {
                    for (int five = 0; five <= pcsFiveBGN; five++)
                    {
                            if (one * 1 + two * 2 + five * 5 == sumBGN)
                            {
                                Console.WriteLine($"{one} * 1 lv. + {two} * 2 lv. + {five} * 5 lv. = {sumBGN} lv.");
                            }
                    }
                }
            }
        }
    }
}
