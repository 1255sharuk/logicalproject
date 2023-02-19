using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Prog_Exam
{
    class Average_Array
    {
        static void Main()
        {
            int[] arr = {10,34,51,67,23};
           
            int sum = 0;
            float average = 0.0F;

            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }

            average = (float)sum / arr.Length;

            Console.WriteLine("Average of Array elements: " + average);
        }
    }
    
}
