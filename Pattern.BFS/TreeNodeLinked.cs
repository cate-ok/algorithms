using System;

namespace Pattern.BFS
{
    class TreeNodeLinked
    {
        public int Value { get; set; }
        public TreeNodeLinked Left { get; set; }
        public TreeNodeLinked Right { get; set; }
        public TreeNodeLinked Next { get; set; }

        public TreeNodeLinked(int x)
        {
            Value = x;
            Left = Right = Next = null;
        }
    }
}
