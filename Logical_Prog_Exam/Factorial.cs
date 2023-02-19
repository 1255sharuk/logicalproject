using System;

namespace Logical_Prog_Exam
{
    class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for(int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of a number " + num + "!" + " = " + fact);
            Console.ReadLine();
        }
    }
}
