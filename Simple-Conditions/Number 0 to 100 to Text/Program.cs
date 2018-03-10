using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_0_to_100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter an integer number (1 ... 100): ");

            var num = int.Parse(Console.ReadLine());

                string str = null;

                int unit = num % 10;

                int tenth = num / 10;

                string[] units = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
                string[] teens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "sventeen", "eightteen", "nineteen" };
                string[] tenths = { null, "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };



                if (num < 10 && num >= 0)
                    str = units[unit];

                if (num >= 10 && num < 20)
                    str = teens[unit];

                if (num >= 20 && num < 100)
                {
                    if (unit == 0)
                        str = tenths[tenth];
                    else
                        str = tenths[tenth] + " " + units[unit];
                }

                if (num == 100)
                    str = "one hundred";

                if (num < 0 || num > 100)
                    str = "invalid number";

            Console.WriteLine(str);
        }
    }
}
