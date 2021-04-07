﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace anagramsolver
{
    public static class anagramCal
    {
        
       public static IEnumerable<IEnumerable<T>> Anagrams<T>(this IEnumerable<T> collection) where T : IComparable<T>
        {
            var total = collection.Count();

            // provided str text get all subsets
            var subsets = collection.Permutations()
                .SelectMany(c => Enumerable.Range(1, total).Select(i => c.Take(i)))
                .Distinct(new CollectionComparer<T>());

            return subsets;
        }

       public static IEnumerable<IEnumerable<T>> Permutations<T>(this IEnumerable<T> collection)
       {
           return collection.Count() > 1
               ?
               from ch in collection
               let set = new[] { ch }
               from permutation in collection.Except(set).Permutations()
               select set.Union(permutation)
               :
               new[] { collection };
       }

       public static string MergeToStr(this IEnumerable<char> chars)
       {
           return new string(chars.ToArray());
       }
    }


    public class CollectionComparer<T> : IEqualityComparer<IEnumerable<T>> where T : IComparable<T>
    {
        Dictionary<IEnumerable<T>, int> dict = new Dictionary<IEnumerable<T>, int>();

        public bool Equals(IEnumerable<T> x, IEnumerable<T> y)
        {
            if (x.Count() != y.Count())
                return false;
            return x.Zip(y, (xi, yi) => xi.Equals(yi)).All(compareResult => compareResult);
        }

        public int GetHashCode(IEnumerable<T> obj)
        {
            var inDict = dict.Keys.FirstOrDefault(k => Equals(k, obj));
            if (inDict != null)
                return dict[inDict];
            else
            {
                int n = dict.Count;
                dict[obj] = n;
                return n;
            }
        }
    }// class
}