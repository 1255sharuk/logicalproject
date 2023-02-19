using System;
using System.Collections.Generic;
using System.Text;

namespace logicalproject
{
    class sum_of_digits_of_num_until_single_digit
    {
        static void Main()
        {
            Console.Write("Enter a num to find sum of its digits until single digit: ");
            int n = int.Parse(Console.ReadLine());
            int rem, sum = 0;
            do
            {
                if (sum != 0)
                {
                    n = sum;
                    sum = 0;
                }
                while (n > 0)
                {
                    rem = n % 10;
                    sum = sum + rem;
                    n = n / 10;
                }
            } while (sum > 9);
            Console.WriteLine("sum of digits: " + sum);
            Console.ReadKey();
        }
    }
}
