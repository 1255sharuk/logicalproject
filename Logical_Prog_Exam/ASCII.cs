using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Prog_Exam
{
    class ASCII
    {
        static void Main()
        {

            char c;
            Console.WriteLine("Enter a character: ");
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\nASCII Value of " + c + " " + Convert.ToInt32(c));
            Console.ReadKey();
        }
    }
}
