using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Prog_Exam
{
    class Even_Odd_SwitchCase//to check even or odd by using switch case
    {
        static void Main()
        {
            Console.WriteLine("Enter a number to check even or odd number");
            int num = int.Parse(Console.ReadLine());
            switch (num % 2)
            {
                case 0:
                    Console.WriteLine(num + " is a even number");
                    break;
                case 1:
                    Console.WriteLine(num + " is an odd number");
                    break;
            }
            Console.ReadKey();
        }
    }
}
