using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string contractPeriod = Console.ReadLine();
            string contractType = Console.ReadLine();
            string hasInternet = Console.ReadLine();
            int month = int.Parse(Console.ReadLine());

            var singlePrice = 0.00;

            if (contractPeriod == "one")
            {
                switch (contractType)
                {
                    case "Small": singlePrice = 9.98; break;
                    case "Middle": singlePrice = 18.99; break;
                    case "Large": singlePrice = 25.98; break;
                    case "ExtraLarge": singlePrice = 35.99; break;
                }
            }

            else if (contractPeriod == "two")
            {
                switch (contractType)
                {
                    case "Small": singlePrice = 8.58; break;
                    case "Middle": singlePrice = 17.09; break;
                    case "Large": singlePrice = 23.59; break;
                    case "ExtraLarge": singlePrice = 31.79; break;
                }
            }


            if (hasInternet == "yes" && singlePrice <= 10)
            {
                singlePrice += 5.50;
            }

            else if (hasInternet == "yes" && singlePrice <= 30)
            {
                singlePrice += 4.35;
            }

            else if (hasInternet == "yes" && singlePrice > 30)
            {
                singlePrice += 3.85;
            }


            var fee = month * singlePrice;

            if (contractPeriod == "two")
            {
                fee *= (1 - 0.0375);
            }

            Console.WriteLine($"{fee:f2} lv.");

        }
    }
}
