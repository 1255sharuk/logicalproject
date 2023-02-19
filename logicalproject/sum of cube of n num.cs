using System;
using System.Collections.Generic;
using System.Text;

namespace logicalproject
{
    class sum_of_cube_of_n_num

    {
        static void Main()
        {

            Console.WriteLine("Enter n val: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            //calculating sum of cubes from 1 to n
            for (int i = 1; i <= n; i++)
                sum += (i * i * i);

            Console.WriteLine("Sum is: " + sum);
        }
    }
}
