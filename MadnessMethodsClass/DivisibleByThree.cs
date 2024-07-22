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
            // convert given string to int
            int intToCheck = int.Parse(n);

            // divide int by 3 and convert to double
            double num = intToCheck / 3;
            Console.WriteLine("num: " + num); // console log to check logic

            // convert the double to a string, so that we can check if it contains a period
            // which would signify it is a decimal, therefore not divisible by 3
            string stringNum = num.ToString();
            Console.WriteLine("stringNum: " + stringNum); // console log to check logic

            // if the string contains a . we return false because it is not divisible by 3
            if (stringNum.Contains('.'))
            {
                Console.WriteLine("false"); // console log to check logic
                return false;
            }
            else // if the string does not contain a . we return true since it is a whole number and divisible by 3
            {
                Console.WriteLine("true"); // console log to check logic
                return true;
            }

            // if the code above is not reached, throw an exception
            throw new NotImplementedException();
        }
    }
}
