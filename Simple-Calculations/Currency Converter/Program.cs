using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input value to be converted: ");
            var val = double.Parse(Console.ReadLine());

            Console.Write("Input currency (BGN, USD, EUR or GBP): ");
            string inCurr = (Console.ReadLine());

            Console.Write("Output currency (BGN, USD, EUR or GBP): ");
            string outCurr = (Console.ReadLine());

            //Convert to BGN

            double midConvert = 1;

            if (inCurr == "USD")
            {
                midConvert = 1.79549 * val;
            }
            if (inCurr == "EUR")
            {
                midConvert = 1.95583 * val;
            }
            if (inCurr == "GBP")
            {
                midConvert = 2.53405 * val;
            }
            if (inCurr == "BGN")
            {
                midConvert = 1 * val;
            }

            double output = 1;

            if (outCurr == "USD")
            {
                output = midConvert / 1.79549;
            }
            if (outCurr == "EUR")
            {
                output = midConvert / 1.95583;
            }
            if (outCurr == "GBP")
            {
                output = midConvert / 2.53405;
            }
            if (outCurr == "BGN")
            {
                output = midConvert / 1;
            }

            Console.WriteLine(Math.Round(output, 2) + " "+ outCurr);
        }
    }
}
