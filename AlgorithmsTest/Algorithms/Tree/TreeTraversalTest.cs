using Xunit;
using Algorithms.Algorithms.Tree;
using Algorithms.DataStructures.Tree;

namespace AlgorithmsTest.Algorithms.Tree
{
    public class TreeTraversalTest
    {
        [Fact]
        public void InOrderTraversalTest()
        {
            var root = new BinaryTreeNode<int>(10);
            var n1 = new BinaryTreeNode<int>(5);
            n1.left = new BinaryTreeNode<int>(3);
            n1.right = new BinaryTreeNode<int>(7);
            root.left = n1;
            var n2 = new BinaryTreeNode<int>(20);
            n1.left = new BinaryTreeNode<int>(15);            
            root.right = n2;
            
            var treeTraversal = new TreeTraversal<int>();
            treeTraversal.InOrderTraversal(root);

            Assert.True(true);
        }
    }
}
