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
            Console.WriteLine("Please enter an integer number [0..999] and press Enter.");
            uint num = uint.Parse(Console.ReadLine());


            uint hundred = num / 100;
            uint tenth = (num / 10) % 10;
            uint unit = num % 10;

            Console.WriteLine(hundred);
            Console.WriteLine(tenth);
            Console.WriteLine(unit);

            string str = null;

                string[] units = { null, "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "sventeen", "eightteen", "nineteen" };
                string[] uintsCaps = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eightteen", "Nineteen" };
                string[] tenths = { null, "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
                string[] tenthsCaps = { null, "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

                if ((num >= 0) && (num <= 19))
                {
                    str = uintsCaps[num];
                }

                if ((num >= 20) && (num <= 99))
                {
                    str = tenthsCaps[tenth] + " " + units[unit];
                }

                if ((num >= 100) && (tenth == 0) && (unit == 0))
                {
                    str = uintsCaps[hundred] + " hundred";
                }

                if ((num >= 100) && (tenth == 0) && (unit != 0))
                {
                    str = uintsCaps[hundred] + " hundred and " + units[unit];
                }

                if ((num >= 100) && (tenth != 0))
                {
                    str = uintsCaps[hundred] + " hundred and " + tenths[tenth] + " " + units[unit];
                }

                Console.WriteLine(str);
        }
    }
}
