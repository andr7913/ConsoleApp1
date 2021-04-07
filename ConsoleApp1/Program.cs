using System;
using System.Collections.Generic;
using System.Linq;
using anagramsolver;


static class Program
{
    static void Main(string[] args)
    {
       
        Console.WriteLine("Write something: ");
        var text = Console.ReadLine();
        var res = anagramCal.Anagrams(text);

        foreach (var anagram in res)
            Console.WriteLine(anagram.MergeToStr());
    }

}// class