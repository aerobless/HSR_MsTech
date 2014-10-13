using System.Collections.Generic;

namespace LambdaExpressions1
{
    public delegate bool KeyValueFilter<K, V>(K key, V value);
    
    public static class ExtensionMethods
    {
        public static Dictionary<K, V> FilterBy<K, V>(this Dictionary<K, V> items, KeyValueFilter<K, V> filter)
        {
            var result = new Dictionary<K, V>();

            foreach (KeyValuePair<K, V> element in items)
            {
                if (filter(element.Key, element.Value))
                    result.Add(element.Key, element.Value);
            }

            return result;
        }
    }
}
