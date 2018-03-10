using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input type of figure (square, rectangle, circle or triangle): ");
            string figType = Console.ReadLine().ToLower();

            double figArea = 0; 

            if (figType == "square")
            {
                Console.Write("Input a: ");
                var a = double.Parse(Console.ReadLine());

                figArea = a * a;
            }

            else if (figType == "rectangle")
            {
                Console.Write("Input a: ");
                var a = double.Parse(Console.ReadLine());
                Console.Write("Input b: ");
                var b = double.Parse(Console.ReadLine());
                figArea = a * b;
            }

            if (figType == "circle")
            {
                Console.Write("Input r: ");
                var r = double.Parse(Console.ReadLine());

                figArea = Math.PI * r * r;
            }

            else if (figType == "triangle")
            {
                Console.Write("Input a: ");
                var a = double.Parse(Console.ReadLine());
                Console.Write("Input h: ");
                var h = double.Parse(Console.ReadLine());
                figArea = a * h / 2;
            }

            Console.WriteLine(Math.Round(figArea,3));
        }
    }
}
