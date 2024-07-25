using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MadnessMethodsClass.ReverseLongWords
{
    public static class MMB
    {
        public static IEnumerable<string> MMReverseLongWords (this IEnumerable<string> input)
        {
            foreach (var word in input)
            {
                yield return word.Length >=5 ? Reverse(word) : word;
            }
        }

        // helper method to reverse a single string
        private static string Reverse (string word)
        {
            char[] arr = word.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
