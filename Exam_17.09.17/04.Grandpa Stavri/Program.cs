using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grandpa_Stavri
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());

            var liters = 0.0;

            var literDegree = 0.0;

            var totalLiterDegrees = 0.0;

            for (int i = 1; i <= days; i++)
            {
                var inputLiters = double.Parse(Console.ReadLine());
                liters += inputLiters;

                var inputDegrees = double.Parse(Console.ReadLine());

                literDegree = inputLiters * inputDegrees;

                totalLiterDegrees += literDegree;
            }

            var averageDegree = totalLiterDegrees / liters; 

            Console.WriteLine($"Liter: {liters:f2}");
            Console.WriteLine($"Degrees:{averageDegree:f2}");

            if (averageDegree < 38) Console.WriteLine("Not good, you should baking!");

            else if (averageDegree >= 38 && averageDegree < 42) Console.WriteLine("Super!");

            else Console.WriteLine("Dilution with distilled water!");

        }
    }
}
