using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Prog_Exam
{
    class Remove_Dup_Char
    {
        static void Main()
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            string Remstr = string.Empty;
            for(int i = 0; i < str.Length; i++)
            {
                if (!Remstr.Contains(str[i]))
                {
                    Remstr= Remstr+ str[i];
                    //Remstr += str[i];
                }
            }
            Console.WriteLine("String after remove duplicate characters: " + Remstr);
        }
    }
}
