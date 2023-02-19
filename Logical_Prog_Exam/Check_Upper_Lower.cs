using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Prog_Exam
{
    class Check_Upper_Lower
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine(ch + " is lowercase alphabet ");
            }
            else if (ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine(ch + " is uppercase alphabet ");
            }
            else
            {
                Console.WriteLine(ch + " is not an alphabet ");
            }

            Console.ReadLine();
        }
    }
}
