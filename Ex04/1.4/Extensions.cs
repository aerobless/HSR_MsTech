using System;
using System.Collections;
using System.Collections.Generic;

namespace ExtensionMethods
{
    /// <summary>
    /// Dokumentation der offiziellen LINQ Extension Methods:
    /// http://msdn.microsoft.com/en-us/library/system.linq.enumerable_methods.aspx
    /// 
    /// Nutzen Sie diese Dokumentation um Ihre Extension Methods zu implementieren.
    /// Sie finden dort auch die Beschreibung, was die Methode effektiv für einen Effekt hat.
    /// </summary>
    public static class Extensions
    {
        public static void HSRForEach<TSource>(this IEnumerable<TSource> source, Action<TSource> action)
        {
            foreach (TSource item in source)
                action(item);
        }

        /* to do
         * 
         *  HSRWhere
         *  HSROfType
         *  HSRToList

         *  HSRAggregate
         *  HSRSum
         *  
         */

    }
}


