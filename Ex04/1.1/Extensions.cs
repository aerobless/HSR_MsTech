using System;
using System.Linq;
using System.Text;

namespace ExtensionMethods
{
    public static class Extensions
    {
        /*
         * Extension method has to meet the following criteria:
         * 1. static class
         * 2. static method
         * 3. first param must be declared with "this" and must denote the class, to which the
         *    method should be added.
         */
        public static string CamelCase(this string s)
        {
            return ToCamelCaseInternal(s);
        }
        private static string ToCamelCaseInternal(string s)
        {
            string newString = "";
            bool sawUnderscore = false;

            foreach (char c in s)
            {
                if ((newString.Length == 0) && Char.IsLetter(c))
                    newString += Char.ToUpper(c);
                else if (c == '_')
                    sawUnderscore = true;
                else if (sawUnderscore)
                {
                    newString += Char.ToUpper(c);
                    sawUnderscore = false;
                }
                else
                    newString += c;
            }

            return newString;
        }
    }
}

