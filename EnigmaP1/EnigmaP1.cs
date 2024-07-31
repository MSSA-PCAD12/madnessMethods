using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EnigmaP1
{
    //create a class Plugboard
    public class Plugboard
    {
        //create a dictionary to store the mappings encapsulated in a private static readonly field to apply OOP
        private static readonly Dictionary<char, char> dictionary = new();
        private readonly Dictionary<char, char> _mappings = dictionary;
        //create a constructor that takes a string wirePairs
        public Plugboard(string wirePairs)
        { 
            //create a method to validate the wirePairs
            Console.WriteLine(wirePairs);
            if (wirePairs.Length > 20)
            {//throw an exception if the wirePairs is greater than 20
                throw new ArgumentException("Invalid wire - too many wires");
            }

            //check if the length of wirePairs is odd
            if (wirePairs.Length % 2 != 0)
            {
                throw new ArgumentException("Invalid wire pairs: must be an even number of characters");
            }
            //create a loop to iterate through the wirePairs
            for (int i = 0; i < wirePairs.Length; i += 2)
            {//create a variable input to store the first character of the wirePairs
                char input = char.ToUpper(wirePairs[i]);
                char output = char.ToUpper(wirePairs[i + 1]);
                //check if the input and output are not letters
                if (!char.IsLetter(input) || !char.IsLetter(output))
                {//throw an exception
                    throw new ArgumentException("Invalid wire pairs: only letters allowed");
                }
                //check if the input and output are the same
                if (_mappings.ContainsKey(input) || _mappings.ContainsKey(output))
                {//throw an exception
                    throw new ArgumentException("Duplicate or conflicting wire pairs");
                }
                //add the input and output to the dictionary
                _mappings[input] = output;
                _mappings[output] = input;
            }
        }//create a method to process the input
        public char process(char input)
        {
            Console.WriteLine(input);
            //convert the input to uppercase
            char upperInput = char.ToUpper(input);
            //return the output if the input is in the dictionary
            return _mappings.TryGetValue(upperInput, out char output) ? output : upperInput;
        }
    }
}