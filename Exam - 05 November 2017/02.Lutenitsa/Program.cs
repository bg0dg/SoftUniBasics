using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Lutenitsa
{
    class Program
    {
        static void Main(string[] args)
        {
            double qtyTommInKg = double.Parse(Console.ReadLine());

            double numBoxes = double.Parse(Console.ReadLine());
            double numJars = double.Parse(Console.ReadLine());

            double totalLut = qtyTommInKg / 5; //произведена лютеница

            var jarsNumUsed = totalLut / 0.535; //произведени буркани

            var boxesUsed = jarsNumUsed / numJars; //произведени касетки

            var boxesLeft = Math.Abs(boxesUsed - numBoxes); //оставащи касетки

            var jasrLeft = Math.Abs(jarsNumUsed - (numBoxes * numJars)); //оставащи буркани

            if (boxesUsed > numBoxes)
            {

                Console.WriteLine($"Total lutenica: {Math.Floor(totalLut)} kilograms.");
                Console.WriteLine($"{Math.Floor(boxesLeft)} boxes left.");
                Console.WriteLine($"{Math.Floor(jasrLeft)} jars left.");
            }

            else
            {
                Console.WriteLine($"Total lutenica: {Math.Floor(totalLut)} kilograms.");
                Console.WriteLine($"{Math.Floor(boxesLeft)} more boxes needed.");
                Console.WriteLine($"{Math.Floor(jasrLeft)} more jars needed.");
            }

        }
    }
}
