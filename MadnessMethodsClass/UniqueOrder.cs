﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadnessMethodsClass
{
    public class Unique
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            if (iterable == null)
                return new List<T>();

            var unique = new List<T>();
            T? previous = default;
            bool isFirst = true;

            foreach (T item in iterable)
            {
                if (isFirst || !item!.Equals(previous)) // !. lets it know it won't be null
                {
                    unique.Add(item);
                    previous = item;
                    isFirst = false;
                }
            }

            return unique;
        }

        public static IEnumerable<T> UniqueInOrder2<T>(IEnumerable<T> iterable)
        {
            if (iterable == null) yield break;

            T? previous = default;

            foreach (T item in iterable)
            {
                if (previous == null || !item!.Equals(previous))
                {
                    yield return item; // !. lets it know it won't be null
                    previous = item;
                }
            }
        }
    }
}
