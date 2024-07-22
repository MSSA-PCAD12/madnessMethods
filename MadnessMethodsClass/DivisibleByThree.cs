using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MadnessMethodsClass
{
    internal class Three
    {
        public static bool DivisibleByThree(string n)
        {
            if (n == "")
            {

            return false;
            }
            int sum = 0;

            // Step 1: Sum the digits
            foreach (char digit in n)
            {
                sum += digit - '0'; // Convert char to int
            }

            // Step 2: Check divisibility by 3 without using the modulo operator
            while (sum >= 3)
            {
                sum -= 3;
            }

            return sum == 0;
        }
    }

}

