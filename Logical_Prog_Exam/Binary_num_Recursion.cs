using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Prog_Exam
{
    class Binary_num_Recursion
    {
        // to Print Binary Equivalent of an Integer using Recursion
       public static void Main(String[] args)
        {
         
            Binary_Conversion bc = new Binary_Conversion();
            Console.WriteLine("Enter Decimal Number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Binary Equivalent of a number: ");
            bc.BinaryConver(num);
            Console.ReadLine();
        }
    }
    class Binary_Conversion
    {
        public int BinaryConver(int num)
        {
            int bin;
            if (num != 0)
            {               
                bin = (num % 2) + 10 * BinaryConver(num / 2);
                Console.WriteLine(bin);
                return 0;
            }
            else
            {
                return 0;
            }
        }

    }

}
