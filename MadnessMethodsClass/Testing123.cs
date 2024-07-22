using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadnessMethodsClass
{
    public static class Testing123
    {
        public static List<string> Testing123Method(List<string> stringList)
        {
            // given: ["a", "b", "c"]
            // output needs to be: ["1: a", "2: b", "3: c"]

            // init outputList to store the output
            List<string> outputList = new List<string>();


            for (int i = 0; i < stringList.Count; i++)
            {
                // convert the given string to a stringbuilder
                StringBuilder sb = new StringBuilder(stringList[i]);

                // insert the line number, a colon, and a space
                sb.Insert(0, $"{i + 1}: ");
                outputList.Add(sb.ToString());
            }

            return outputList;
        }
    }
}
