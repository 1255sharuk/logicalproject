using System;
using System.Collections.Generic;
using System.Text;

namespace logicalproject
{
    class no_of_char_in_str
    {
        static void Main()
        {

            Console.Write("Enter a String: ");
            string input = Console.ReadLine();
            int len = 0;
            foreach (char ch in input)
            {
                if(ch!=32)
                 len += 1;
            }
            Console.WriteLine("no. of char in given string " + len);
        }
    }
}
