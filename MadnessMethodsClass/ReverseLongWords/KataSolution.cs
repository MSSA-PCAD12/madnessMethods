using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadnessMethodsClass.ReverseLongWords
{
    public class KataSolution
    {
        public static string SpinWords(string sentence)
        {
            IEnumerable<string> splittedString = sentence.MMSplitString();
            // extension methods
            IEnumerable<string> splittedWithLongWordsReversed = splittedString.MMReverseLongWords();
            // another extension method just to reverse the Long string and ignore words < 5 char
            string solution = splittedWithLongWordsReversed.MMJoinString();
            // one more extension method that will combine all the string in to 1 final solution

        }
    }
}
