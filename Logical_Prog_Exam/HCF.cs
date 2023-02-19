using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Prog_Exam
{
    class HCF
    {
        static void Main()
        {
            int i, num1, num2, min, HCF = 1;
            // Reading 2 numbers from user
            Console.WriteLine("Enter First number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            // Find min number between two numbers
            min = (num1 < num2) ? num1 : num2;
            for (i = 1; i <= min; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    HCF = i;
                }
            }
            Console.WriteLine("HCF of " + num1 + " and " + num2 + " is: " + HCF);
            Console.ReadLine();
        }
    }
}
