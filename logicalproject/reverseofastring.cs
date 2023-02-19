using System;
using System.Collections.Generic;
using System.Text;

namespace logicalproject
{
    class reverseofastring
    {
        static void Main()
        {
            Console.Write("enter a string: ");
            string input = Console.ReadLine();
            string reverse = " ";
            foreach (char ch in input)
                reverse = ch + reverse;
            Console.WriteLine("reverse of a string: " + reverse);

        }
    }
}
