
namespace Algorithms.DataStructures.Tree
{
    /// <summary>
    /// Prefix tree
    /// </summary>
    public class Trie
    {
        public TrieNode root;

        public Trie()
        {
            this.root = new TrieNode('*');
        }

        public Trie(string[] words)
        {            
            for (var i = 0; i < words.Length; i++)
            {
                this.Add(words[i]);
            }
        }

        public void Add(string word)
        {
            AddWord(this.root, word);
        }

        public bool Search(string pref)
        {
            return isPathExist(this.root, pref);
        }

        private bool isPathExist(TrieNode node, string word)
        {
            var nodes = node.children;
            for (var i = 0; i < nodes.Count; i++)
            {
                if (nodes[i].value == word[0])
                {
                    if (word.Length == 1)
                        return true;
                    if (nodes[i].children.Count == 0)
                        return false;
                    return isPathExist(nodes[i], word.Substring(1));
                }
            }
            return false;
        }

        private void AddWord(TrieNode node, string word)
        {
            var nodes = node.children;
            for (var i = 0; i < nodes.Count; i++)
            {
                if (nodes[i].value == word[0])
                {
                    if (word.Length == 1)
                    {
                        nodes[i].isLast = true;
                        return;
                    }
                    if (nodes[i].children.Count == 0)
                    {
                        AddBranch(nodes[i], word.Substring(1));
                        return;
                    }                    
                    AddWord(nodes[i], word.Substring(1));
                    return;                    
                }
            }
            AddBranch(node, word);
        }

        private void AddBranch(TrieNode startNode, string word)
        {
            var curNode = startNode;            
            for (var i = 0; i < word.Length; i++)
            {
                var isLast = (i == word.Length - 1);
                var node = new TrieNode(word[i], isLast);
                curNode.children.Add(node);
                curNode = node;
            }
        }
    }
}
