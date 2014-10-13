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

        /* Filters a sequence of values based on a predicate. 
         * http://msdn.microsoft.com/en-us/library/bb534803.aspx
         */
        public static IEnumerable<TSource> HSRWhere<TSource>(
	        this IEnumerable<TSource> source,
	        Func<TSource, bool> predicate
        )
        {
            List<TSource> result = new List<TSource>();
            foreach (TSource item in source)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        /* Filters the elements of an IEnumerable based on a specified type.
         * http://msdn.microsoft.com/en-us/library/bb360913.aspx
         */
        public static IEnumerable<TResult> HSROfType<TResult>(this IEnumerable source)
        {
            List<TResult> resultList = new List<TResult>();
            foreach (Object item in source)
            {
                if (item is TResult)
                {
                    resultList.Add((TResult)item);
                }
            }
            return resultList;
        }

        /* Creates a List<T> from an IEnumerable<T>.
         * http://msdn.microsoft.com/en-us/library/bb342261.aspx
         */
        public static List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
        {
            List<TSource> resultList = new List<TSource>();
            foreach (TSource item in source)
            {
                resultList.Add(item);
            }
            return resultList;
        }

        /* Applies an accumulator function over a sequence.
         * The specified seed value is used as the initial accumulator value.
         * http://msdn.microsoft.com/en-us/library/bb549218.aspx
         */
        public static TAccumulate HSRAggregate<TSource, TAccumulate>(
	        this IEnumerable<TSource> source,
            TAccumulate seed,
            Func<TAccumulate, TSource, TAccumulate> func
        )
        {
            foreach (TSource item in source)
            {
                seed = func(seed, item);
            }
            return seed;
        }

        /* Computes the sum of the sequence of Int32 values that are obtained by invoking a
         * transform function on each element of the input sequence.
         * http://msdn.microsoft.com/en-us/library/bb535184.aspx
         */
        public static int HSRSum<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, int> selector
        )
        {
            int result = 0;
            foreach (TSource item in source)
            {
                result += selector(item);
            }
            return result;
        }
    }
}


