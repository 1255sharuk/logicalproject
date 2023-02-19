using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Prog_Exam
{
    class Pyramid
    {
        static void Main()
        {
            Console.WriteLine("Enter no.of Rows");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            //for(int i = num; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            //int Space, Number;
            //Console.WriteLine("Print paramid");
            //for (int i = 1; i <= numberoflayer; i++) // Total number of layer for pramid  
            //{
            //    for (Space = 1; Space <= (numberoflayer - i); Space++) // Loop For Space  
            //        Console.Write(" ");
            //    for (Number = 1; Number <= i; Number++) //increase the value  
            //        Console.Write('*');
            //    for (Number = (i - 1); Number >= 1; Number--) //decrease the value  
            //        Console.Write('*');
            //    Console.WriteLine();
            //}
        }
    }
}
