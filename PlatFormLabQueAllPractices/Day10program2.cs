using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
        Write a C# program to find the maximum number in a single-dimensional integer array.
        Input: { 5, 10, 3, 25, 2 }
        Output: 25 
 */


namespace PlatFormLabQueAllPractices
{
    internal class Day10program2
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 10, 3, 25, 2 };
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max) 
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine("Maximum Number: " + max);

        }
    }
}
