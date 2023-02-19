using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Prog_Exam
{
    class Evn_Num_1toN
    {
        static void Main()
        {
            int sum = 0;
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            for(int i = 2; i <= n; i += 2)
            {
                sum=sum+i;
            }
            Console.WriteLine("Sum of " + n + " even numbers " + sum);
        }
    }
}
