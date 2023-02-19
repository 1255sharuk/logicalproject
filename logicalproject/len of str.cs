using System;
using System.Collections.Generic;
using System.Text;

namespace logicalproject
{
    class len_of_str
    {
        static void Main()
        {
            Console.Write("Enter a String: ");
            string input = Console.ReadLine();
            int len = 0;
            foreach(char ch in input)
            {
                    len += 1;
            }
            Console.WriteLine("len of given string " + len);
      
        }
    }
}
