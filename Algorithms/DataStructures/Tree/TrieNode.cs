using System.Collections.Generic;

namespace Algorithms.DataStructures.Tree
{
    public class TrieNode
    {
        public char value;
        public List<TrieNode> children;
        public bool isLast;

        public TrieNode(char value, bool isLast=false)
        {
            this.value = value;
            this.children = new List<TrieNode>();
            this.isLast = isLast;
        }
    }
}
