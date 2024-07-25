using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MadnessMethodsClass.ReverseLongWords
{
    public static class MMC
    {
        public static string MMCombineString(this IEnumerable<string> input)
        {
            // given an IEnumerable<string>
            // return a string that combines all the strings and seperates them with a space

            // init a string so that we can add the strings and spaces
            string output = "";

            // loop through given IEnumerable<string> and add each item to the string
            foreach (string s in input)
            {
                output += s + " ";
            }

            // trim the trailing space of the string
            return output.TrimEnd();
        }
    }
}
