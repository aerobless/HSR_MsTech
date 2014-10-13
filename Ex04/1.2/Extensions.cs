using System.Linq;
using System.Text;

namespace ExtensionMethods
{
    public static class Extensions
    {
        public static string SafeToString(this object obj){
            // If the object is empty we return an empty string instead of causing an
            // exception.
            return obj == null ? string.Empty : obj.ToString();
        }
    }
}

