using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
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
