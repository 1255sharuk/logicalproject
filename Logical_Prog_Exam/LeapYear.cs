using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Prog_Exam
{
    class LeapYear//using Conditional operator
    {
        static void Main()
        {
            int year;
            Console.WriteLine("Enter Year");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((year % 4 == 0 && year % 100 != 0) ? "LEAP YEAR" : (year % 400 == 0) ?"LEAP YEAR" : "NOT LEAP YEAR");
            Console.ReadLine();
        }

    }
}
