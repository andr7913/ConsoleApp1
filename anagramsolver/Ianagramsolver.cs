using System.Collections.Generic;

namespace anagramsolver
{
    public interface Ianagramsolver
    {
        public void SetDictionary(List<string> dictionary);
        public string Getbestvalueword(List<char> letters);
        public List<string> getTopwords(List<char> letters, int Topcount);
        public void addWord(string newWord);
        public void removeWord(string removeWord);
    }
}