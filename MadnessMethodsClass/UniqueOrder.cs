using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadnessMethodsClass
{
    internal class Unique
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            if (iterable == null)
                return new List<T>();

            var unique = new List<T>();
            T previous = default(T);
            bool isFirst = true;

            foreach (var item in iterable)
            {
                if (isFirst || !item.Equals(previous))
                {
                    unique.Add(item);
                    previous = item;
                    isFirst = false;
                }
            }

            return unique;
        }
}
