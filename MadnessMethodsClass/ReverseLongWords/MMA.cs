using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadnessMethodsClass.ReverseLongWords
{
    public static class MMA
    {
        public static IEnumerable<string> MMSplitString(this string input)
        {
            // Initialize variables - create empty list to store words and set start index to 0
            // iterate through the input string
            // check for space character
            // if the cur char is a space:
                // check if there is a word to add (if current index is > start index)
                // add substring from teh start index to the current index to the list of words
                // update start index to the current index + 1
            // add last word
                // after loop, check if there is any remaining word after the last space
                // add the substring from the start index to the end of the string to the list of words
            // return list of words

            if (input == null) throw new ArgumentNullException(nameof(input));

            List<string> words = new List<string>();
            int start = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    if (i > start)
                    {
                        words.Add(input.Substring(start, i - start));
                    }
                    start = i + 1;
                }
            }

            if (start < input.Length)
            {
                words.Add(input.Substring(start));
            }

            return words;
        }
    
    }
}
