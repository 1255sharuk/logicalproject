using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Prog_Exam
{
    class Occurence_String
    {
        static void Main()
        {
            Console.WriteLine("Enter the string");
            string stmt = Console.ReadLine();
            stmt = stmt.Replace(" ", string.Empty);//To remove the spaces in a string
            while (stmt.Length > 0)
            {
                Console.Write(stmt[0] + " : ");
                int count = 0;
                for (int i = 0; i < stmt.Length; i++)
                {
                    if (stmt[0] == stmt[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                stmt = stmt.Replace(stmt[0].ToString(), string.Empty);
            }
            Console.ReadKey();
        }
    }
}
