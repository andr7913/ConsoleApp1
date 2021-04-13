using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace anagramsolver
{
    public class AnagramSolver:IAnagramSolver
    {
        // global list 
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

        public string GetBestValueWord(List<char> letters)
        {
            throw new System.NotImplementedException();
        }

        public List<string> GetTopWords(List<char> letters, int topCount)
        {
            throw new System.NotImplementedException();
        }

        public void AddWord(string newWord)
        {
            if (!dictionaryList.Contains(newWord))
            {
                    dictionaryList.Add(newWord);
            }
        }

        public void RemoveWord(string removeWord)
        {
            if (dictionaryList.Contains(removeWord))
            {
                dictionaryList.Remove(removeWord);
            }
        }

        private int CharacterPoints(int topScore)
        {
            topScore = 0;

            List<char> score1 = new List<char>()
            {
                'e', 'a', 'i', 'o', 'n', 'r', 't', 'l', 's', 'u'
            };

            foreach (var letter in score1)
            {
                topScore++;
            }

            List<char> score2 = new List<char>()
            {
                'd', 'g'
            };

            foreach (var letter in score2)
            {
                topScore += 2;
            }

            List<char> score3 = new List<char>()
            {
                'b', 'c', 'm', 'p'
            };

            foreach (var letter in score3)
            {
                topScore += 3;
            }
            List<char> score4 = new List<char>()
            {
                'f', 'h', 'v', 'w', 'y'
            };

            foreach (var letter in score4)
            {
                topScore += 4;
            }
            List<char> score5 = new List<char>()
            {
                'k'
            };

            foreach (var letter in score5)
            {
                topScore += 5;
            }

            List<char> score8 = new List<char>()
            {
                'j', 'x'
            };

            foreach (var letter in score8)
            {
                topScore += 8;
            }

            List<char> score10 = new List<char>()
            {
                'q', 'z'
            };

            foreach (var letter in score10)
            {
                topScore += 10;
            }

            return topScore;
        }
    }
}