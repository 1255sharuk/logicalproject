using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Prog_Exam
{
    class Count_Substring
    {
        //find number of times a substring appears in the given string
        public static void Main()
        {
            string str;
            string findstring;
            int start = 0;
            int cnt = -1;
            int index = -1;

            Console.Write("Input the original string : ");
            str = Console.ReadLine();
            Console.Write("Input the string to be searched for : ");
            findstring = Console.ReadLine();

            while (start != -1)
            {
                start = str.IndexOf(findstring, index + 1);
                cnt += 1;
                index = start;
            }
            Console.Write("The string '{0}' occurs " + cnt + " times.\n", findstring);
            Console.ReadLine();
        }
    }
}
