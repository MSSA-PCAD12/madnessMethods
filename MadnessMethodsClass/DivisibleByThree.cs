using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadnessMethodsClass
{
    internal class Three
    {
        public static bool DivisibleByThree(string n)
        {

            if (n == String.Empty) return false;

            int sum = 0;

            // loop through the characters in n and convert each of them to an integer
            foreach (char digit in n)
            {
                sum += digit - '0'; // Convert char to int
            }

            // Check if it is divisible by subtracting 3 over and over again
            while (sum >= 3)
            {
                sum -= 3;
            }

            // if the sum is equal to 0, then it is divisible
            return sum == 0;
        }
    }
}
