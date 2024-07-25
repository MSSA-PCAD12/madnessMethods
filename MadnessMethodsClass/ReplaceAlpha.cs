using System;
using System.Collections.Generic;
using System.Linq;
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
                Console.WriteLine($"Processing character: '{c}'"); // Debugging
                if (char.IsLetter(c))
                {
                    int position = c - 'a' + 1;
                    sb.Append(position).Append(' ');
                    Console.WriteLine($"Current StringBuilder: '{sb}'"); // Debugging
                }
            }

            string result = sb.ToString().TrimEnd();
            Console.WriteLine($"Final Result: '{result}'"); // Debugging
            return result;
        }
    }
}
