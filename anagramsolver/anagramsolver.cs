using System;
using System.Collections.Generic;
using System.IO;

namespace anagramsolver
{
    public class anagramsolver:Ianagramsolver
    {
        public List<string> dictionaryList = new List<string>();
        public void SetDictionary(List<string> dictionary)
        {
            // the file has to be in the root folder in your project
            var path = @".\../../../../3000_Common_words.txt";
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
                dictionary.Add(line);

            this.dictionaryList = dictionary;
        }

        public string Getbestvalueword(List<char> letters)
        {
            throw new System.NotImplementedException();
        }

        public List<string> getTopwords(List<char> letters, int Topcount)
        {
            throw new System.NotImplementedException();
        }

        public void addWord(string newWord)
        {
            foreach (var line in dictionaryList)
            {
                if (line.Equals(newWord))
                {
                    Console.WriteLine("this word exist already");
                }
                else
                {
                    dictionaryList.Add(newWord);
                }
            }
           
        }

        public void removeWord(string removeWord)
        {
            foreach (var line in dictionaryList)
            {
                if (line.Equals(removeWord))
                {
                    dictionaryList.Remove(removeWord);
                }
                else
                {
                    Console.WriteLine("ordet findes ikke ");
                }
            }
            
        }
    }
}