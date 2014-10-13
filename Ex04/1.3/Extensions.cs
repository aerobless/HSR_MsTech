using System;
using System.Collections.Generic;

namespace ExtensionMethods
{
    public static class Extensions
    {
        /* 
         * The method has to receive the object from where we're calling first and the
         * action second.
         */
        public static void ForEachElem(this string[] input, Action<string> action)
        {
            for (int i = 0; i < input.Length; i++)
            {
                action(input[i]);
            }
        }
    }
}

