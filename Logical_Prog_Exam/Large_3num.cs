using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Prog_Exam
{
    class Large_3num
    {
        static void Main()
        {
            Console.WriteLine("Enter three number: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("The biggest number is: {0}", a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("The biggest number is: {0}", b);
            }
            else
            {
                Console.WriteLine("The biggest number is: {0}", c);
            }
        }
    }
}
