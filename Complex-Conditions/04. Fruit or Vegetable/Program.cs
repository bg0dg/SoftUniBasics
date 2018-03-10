using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input product [banana, apple, kiwi, cherry, lemon, grapes, tomato, cucumber, pepper or carrot]: ");
            string prod = Console.ReadLine().ToLower();

            if (prod == "banana" || prod == "apple" || prod == "kiwi" || prod == "cherry" || prod == "lemon" || prod == "grapes") 
                Console.Write("fruit");

            else if (prod == "tomato" || prod == "cucumber" || prod == "pepper" || prod == "carrot") 
                Console.WriteLine("vegetable");
            else
                Console.WriteLine("unknown");
        }
    }
}
