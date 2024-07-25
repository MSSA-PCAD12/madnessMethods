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
            IEnumerable<string> splittedWithLongWordsReversed = splittedString.MMReverseLongWords();
            string solution = splittedWithLongWordsReversed.MMJoinString();
            return solution;

        }
    }
}
