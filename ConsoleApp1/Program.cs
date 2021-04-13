using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using anagramsolver;


static class Program
{
    static void Main(string[] args)
    {

        List<string> dictionary = new List<string>();
        var anagramsolver = new anagramsolver.AnagramSolver();
        anagramsolver.SetDictionary(dictionary);
        foreach (var line in dictionary)
        {
            Console.WriteLine(line);
        }

        // anagramsolver.removeWord("zone");

        foreach (var line in dictionary)
         {
             Console.WriteLine(line);
         }

        //Console.WriteLine("Write something: ");
        //var text = Console.ReadLine();
        //var res = anagramCal.Anagrams(text);

        //foreach (var anagram in res)
        //    Console.WriteLine(anagram.MergeToStr());
    }

}