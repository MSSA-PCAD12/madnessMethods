using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadnessMethodsClass
{
    public class FromAtoZClass
    {
        public static string GimmeTheLetters(string sp)
        {
            {

                char first = sp[0];
                char last = sp[sp.Length - 1];

                string result = "";

                for (char i = first; i <= last; i++)
                {
                    result += i;
                }

               return result;
            }


            


        }
    }
}
