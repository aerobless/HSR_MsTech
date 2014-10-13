using System;
using System.Linq;
using System.Text;

namespace ExtensionMethods
{
    public static class Extensions
    {
        //CamelCase hier als Extension-Method implementieren (Funktionalität für das Casing ist in "ToCamelCaseInternal" enthalten).
        //
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

