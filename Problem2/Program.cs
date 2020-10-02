using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
			int num1 = 0;
			int num2 = 1;
			int sum = 0;
			int evenSum = 0;
			int max = 4000000;

			
			while (true)
			{

                sum = num1 + num2; 

				if (sum > max)
					break;

				num1 = num2;
				num2 = sum;
				Console.WriteLine(num2);

				if (sum % 2 == 0)
					evenSum += num2;
			}
			Console.WriteLine("Sum of the even-valued terms: " + evenSum);
		

		Console.ReadKey();
        }
    }
}
