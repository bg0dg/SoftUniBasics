using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());
            var percent = double.Parse(Console.ReadLine());

            var volume = a * b * h; // обем на аквариума в см2

            var liters = volume * 0.001; // общо литри

            var reducedLiters = liters * (1 - percent/100);

            Console.WriteLine("{0:f3}", reducedLiters); //редуцирани литри
            Console.WriteLine(Math.Round(reducedLiters, 3)); //редуцирани литри

        }
    }
}
