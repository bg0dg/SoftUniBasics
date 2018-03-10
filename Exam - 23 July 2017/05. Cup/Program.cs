using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 5 * n;

            int hashCounter = 3 * n;

            for (int row = 1; row <= n / 2; row++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', (width - hashCounter)/2), new string('#', hashCounter));
                hashCounter -=2;
            }

            for (int row = 1; row <= n / 2 + 1; row++)
            {
                hashCounter -= 2;
                Console.WriteLine("{0}#{1}#{0}", new string('.', (width - hashCounter - 2) / 2), new string('.', hashCounter));
                
            }

            hashCounter += 2;
            Console.WriteLine("{0}{1}{0}", new string('.', (width - hashCounter) / 2), new string('#', hashCounter));

            hashCounter += 4;

            for (int row = 1; row <= n / 2; row++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', (width - hashCounter) / 2), new string('#', hashCounter));
            }

            Console.WriteLine("{0}D^A^N^C^E^{0}", new string('.', (width - 10) / 2));

            for (int row = 1; row <= n / 2 + 1; row++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', (width - hashCounter) / 2), new string('#', hashCounter));
            }
        }
    }
}
