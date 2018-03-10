using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sheriff_second_try
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rowWidth = 3 * n;
           
            Console.WriteLine("{0}x{0}", new string('.', (rowWidth - 1) /2 ));          //first up line
            Console.WriteLine("{0}/x\\{0}", new string('.', (rowWidth - 3) / 2));       //second up line
            Console.WriteLine("{0}x|x{0}", new string('.', (rowWidth - 3) / 2));        //third up line
            
            int xCounter = n;                                                           //upper generated lines
            int dotsCounter = (rowWidth - 2 * n - 1) / 2;                                                       
                                                                                                                
            for (int r = 1; r <= (n / 2) + 1; r++)                                                              
            {                                                                                                   
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', dotsCounter), new string('x', xCounter));    
                dotsCounter--;                                                                                  
                xCounter++;                                                                                     
            }                                                                                                


            xCounter = (rowWidth - 3) / 2;                                              //bottom generated lines
            dotsCounter = 1;                                                           
                                                                                                                
            for (int r = 1; r <= n / 2; r++)                                                              
            {                                                                                                   
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', dotsCounter), new string('x', xCounter));    
                dotsCounter++;                                                                                  
                xCounter--;                                                                                     
            }                                                                                                  

            Console.WriteLine("{0}/x\\{0}", new string('.', (rowWidth - 3) / 2));       //top middle line
            Console.WriteLine("{0}\\x/{0}", new string('.', (rowWidth - 3) / 2));       //bottom middle line

            xCounter = n;                                                           //upper generated lines
            dotsCounter = (rowWidth - 2 * n - 1) / 2;

            for (int r = 1; r <= (n / 2) + 1; r++)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', dotsCounter), new string('x', xCounter));
                dotsCounter--;
                xCounter++;
            }

            xCounter = (rowWidth - 3) / 2;                                              //bottom generated lines
            dotsCounter = 1;

            for (int r = 1; r <= n / 2; r++)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', dotsCounter), new string('x', xCounter));
                dotsCounter++;
                xCounter--;
            }

            Console.WriteLine("{0}x|x{0}", new string('.', (rowWidth - 3) / 2));        //third down line
            Console.WriteLine("{0}\\x/{0}", new string('.', (rowWidth - 3) / 2));       //second down line
            Console.WriteLine("{0}x{0}", new string('.', (rowWidth - 1) / 2));          //first down line
        }
    }
}
