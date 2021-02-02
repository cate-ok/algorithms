using Algorithms.DataStructures.Tree;

namespace PracticeApp.Algorithms.Tree
{
    public class TrieCreator
    {
        public Trie CreateTrie(string[] words)
        {
            Trie trie = new Trie();
            for(var i=0; i<words.Length; i++)
            {
                trie.Add(words[i]);
            }
            return trie;
        }
    }
}
