using System;
using System.Collections.Generic;
using System.Text;

namespace logicalproject
{
    class sumofdigits
    {
        static void Main()
        {
            Console.Write("Enter a num to find sum of digits: ");
            int a = int.Parse(Console.ReadLine());
            int re, sum = 0;
            while(a>0)
            {
                re = a % 10;
                sum = sum + re;
                a = a / 10;
            }
            Console.WriteLine("sum of the digits: " + sum);
        }
    }
}
