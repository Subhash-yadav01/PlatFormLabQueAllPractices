using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
        Reverse the Array
        Description: Reverse a given single-dimensional array in-place and print it.
        Input: { 10, 20, 30, 40 }
        Output:  40 30 20 10 
 */

namespace PlatFormLabQueAllPractices
{
    internal class Day10program4
    {
        static void Main(string[] args)
        {
            // Input array
            int[] numbers = { 10, 20, 30, 40 };

            // Reverse in-place using two-pointer approach
            int left = 0, right = numbers.Length - 1;
            while (left < right)
            {
                // Swap elements
                int temp = numbers[left];
                numbers[left] = numbers[right];
                numbers[right] = temp;

                left++;
                right--;
            }

            // Print reversed array
            Console.WriteLine("Reversed Array: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
