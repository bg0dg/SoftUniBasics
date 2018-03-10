using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Input an angle in radians to convert it to degrees: ");
            var aR = double.Parse(Console.ReadLine());
            var aD = aR / (Math.PI / 180) ;
            Console.WriteLine(Math.Round(aD));
        }
    }
}
