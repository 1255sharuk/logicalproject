using System;
using System.Collections.Generic;
using System.Text;

namespace logicalproject
{
    class strongnum
    {
        public static void Main()
        {
            int i, n, n1, s1 = 0, j;
            int fact;
            Console.Write("Input a number to check whether it is Strong number: ");
            n = Convert.ToInt32(Console.ReadLine());
            n1 = n;

            for (j = n; j > 0; j = j / 10)
            {

                fact = 1;
                for (i = 1; i <= j % 10; i++)
                {
                    fact = fact * i;
                }
                s1 = s1 + fact;

            }

            if (s1 == n1)
            {
                Console.Write( n1+" is Strong number");
            }
            else
            {
                Console.Write(n1+" is not Strong number");
            }
            Console.ReadKey();
        }
    }

}

