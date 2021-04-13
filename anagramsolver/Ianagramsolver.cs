using System.Collections.Generic;

namespace anagramsolver
{
    public interface IAnagramSolver
    {
        public void SetDictionary(List<string> dictionary);
        public string GetBestValueWord(List<char> letters);
        public List<string> GetTopWords(List<char> letters, int topCount);
        public void AddWord(string newWord);
        public void RemoveWord(string removeWord);
    }
}