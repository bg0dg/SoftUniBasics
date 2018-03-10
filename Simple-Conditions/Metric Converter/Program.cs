using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value for converting: ");
            var value = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter input unit (mm, cm, m, km, mi, in, ft, yd): ");
            string inUnit = Console.ReadLine().ToLower();

            Console.WriteLine("Enter output unit (mm, cm, m, km, mi, in, ft, yd): ");
            string outUnit = Console.ReadLine().ToLower();

            //Convert value to "m"

            if (inUnit == "mm")
                value = value / 1000;
            else if (inUnit == "cm")
                value = value / 100;
            else if (inUnit == "m")
                value = value / 1;
            else if (inUnit == "km")
                value = value / 0.001;
            else if (inUnit == "mi")
                value = value / 0.000621371192;
            else if (inUnit == "in")
                value = value / 39.3700787;
            else if (inUnit == "ft")
                value = value / 3.2808399;
            else if (inUnit == "yd")
                value = value / 1.0936133;

            //Convert value to output unit

            if (outUnit == "mm")
                value = value * 1000;
            else if (outUnit == "cm")
                value = value * 100;
            else if (outUnit == "m")
                value = value * 1;
            else if (outUnit == "km")
                value = value * 0.001;
            else if (outUnit == "mi")
                value = value * 0.000621371192;
            else if (outUnit == "in")
                value = value * 39.3700787;
            else if (outUnit == "ft")
                value = value * 3.2808399;
            else if (outUnit == "yd")
                value = value * 1.0936133;

            Console.WriteLine(Math.Round(value,8).ToString ("0.00000000"));
        }
    }
}
