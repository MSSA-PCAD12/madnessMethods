using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MadnessMethodsClass
{
    public static class ReplaceAlpha
    {
        public static string AlphabetPosition(string text)
        {
            // init a string builder to hold the alphabet positions

            // loop through the string, one char at a time
            // if the character is a letter carry on, else skip it
            // convert the char to the correct position in the alphabet
            // append the position to the stringbuilder array and add a space

            // return the stringbuilder as a string and trim the inevitable space at the end

            StringBuilder sb = new StringBuilder();

            foreach (char c in text.ToLower())
            {
                // convert to position in alphabet
                if (char.IsLetter(c))
                {
                    int position = c - 'a' + 1;
                    sb.Append(position).Append(' ');
                }
            }

            return sb.ToString().TrimEnd();
        }

        public static string AlphabetPosition2(string text)
        {
            
            StringBuilder sb = new StringBuilder();
            foreach (char c in text.ToLower())
            {
                if (char.IsLetter(c))
                {
                    // checks if char c is a letter
                    if (char.IsLetter(c))
                    {
                        // get alpha position and append to stringbuilder with a space after
                        int position = GetAlphabetPosition(c);
                        sb.Append(position).Append(" ");
                    }
                }
            }
            if (sb.Length > 0)
            {
                sb.Length--; // Remove the last appended space
            }

            return sb.ToString();

            
        }

        private static int GetAlphabetPosition(char c)
            // convert character to ASCII value
            // subtract ASCII value of 'a' from ASCII value of 'char c' to give zero-based index of the character
            // add 1 to convert to one-based index
        {
            return (int)c - (int)'a' + 1;
        }
    }
}
