using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadnessMethodsClass
{
    internal class RemoveSmallest
    {
        // Method to remove the smallest number from an array
    public static int[] RemoveSmallestMethod(int[] numbers)
        {
            // If the array is empty, return the array
            if (numbers.Length == 0)
            {
                return numbers;
            }
            // Find the smallest number in the array
            int min = numbers.Min();
            int[] result = new int[numbers.Length - 1];
            int index = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != min)
                {
                    result[index] = numbers[i];
                    index++;
                }
            }
            return result;
        }
    }
}
