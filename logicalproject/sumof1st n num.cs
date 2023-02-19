using System;
using System.Collections.Generic;
using System.Text;

namespace logicalproject
{
    class sumof1st_n_num
    {
       
        static void Main(string[] args)
        {
            int i, sum = 0;
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                sum = sum + i;

            }
            Console.WriteLine("Sum of first " + num + " natural numbers = " + sum);
        }
    }
}

