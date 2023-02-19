using System;
using System.Collections.Generic;
using System.Text;

namespace logicalproject
{
    class binaryvalueofanum
    {
        static void Main()
        {
            int i;
            Console.Write("enter a num to convert binary");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[16];
            for(i=0;n>0;i++)
            {
                arr[i] = n % 2;
                n = n / 2;
            }
            Console.Write("binary val of a given num is: ");
            for(i=i-1;i>=0;i--)
            {
                Console.Write(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
