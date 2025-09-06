using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
        Count Even and Odd Numbers in Single Dimensional Array
        Description: Count the number of even and odd integers in an array.
        Input: { 1, 2, 3, 4, 5, 6 }
        Output: Even: 3, Odd: 3
 */

namespace PlatFormLabQueAllPractices
{
    internal class Day10program3
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            int CountEven = 0, CountOdd = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    CountEven++;
                }
                else
                {
                    CountOdd++;
                }
            }
            Console.WriteLine("Even: " + CountEven + ", Odd: " + CountOdd);
        }
    }
}
