using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace MadnessMethodsClass
{
    internal class RemoveSmallest
    {
        // Method to remove the smallest number from an array
        public static List<int> RemoveSmallestMethod(List<int> numbers)
        {
            //Check if the input list is empty.If it is, return an empty list.
            //Iterate through the list to find the smallest value.
            //Create a new list.
            //Iterate through the original list, adding elements to the new list except the first occurrence of the smallest value.
            //Return the new list.

            // Check if the list is empty
            if (numbers == null || numbers.Count == 0)
            {
                return new List<int>();
            }

            // Iterate through the list to find the smallest value
            int min = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            // Create a new list
            List<int> result = new List<int>();
            bool found = false;

            // Iterate through the original list
            foreach (int number in numbers)
            {
                if (!found && number == min)
                {
                    found = true; // Skip the first occurrence of the smallest value
                }
                else
                {
                    result.Add(number);
                }
            }

            // Return the new list
            return result;
        }
    }
}
