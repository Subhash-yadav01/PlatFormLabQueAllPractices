using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
         Write a C# Program on Single Dimensional array.

        Input:-

        Enter the Size Of the array:-4

        Enter the Array Element :-
        5
        9
        23
        45

        Output:-

        5 9 23 45
 */

namespace PlatFormLabQueAllPractices
{
    internal class Day10program1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the array elements: ");

            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {

                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nThe Array of Element Output: ");

            foreach (int l in arr)
            {

                Console.Write(l + " ");
            }
        }
    }
}
