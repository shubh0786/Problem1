using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{

//  Problem 1:--------------  If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

//Find the sum of all the multiples of 3 or 5 below 1000.


    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i < 1001; i++)

            {
                Console.WriteLine(i);
                if (i % 3 == 0 || i % 5 == 0)
                    
                    sum += i;
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
