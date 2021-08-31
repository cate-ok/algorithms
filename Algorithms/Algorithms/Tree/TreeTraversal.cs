using Algorithms.DataStructures.Tree;

namespace Algorithms.Algorithms.Tree
{
    public delegate void ProcessNode<T>(BinaryTreeNode<T> n);

    public class TreeTraversal<T>
    {
        public void InOrderTraversal(BinaryTreeNode<T> node, ProcessNode<T> callback)
        {
            if (node!= null) {                
                InOrderTraversal(node.left, callback);
                callback?.Invoke(node);
                InOrderTraversal(node.right, callback);
            }
        }

        public void PreOrderTraversal(BinaryTreeNode<T> node, ProcessNode<T> callback)
        {
            if (node != null)
            {
                callback?.Invoke(node);
                PreOrderTraversal(node.left, callback);
                PreOrderTraversal(node.right, callback);
            }
        }

        public void PostOrderTraversal(BinaryTreeNode<T> node, ProcessNode<T> callback)
        {
            if (node != null)
            {
                PostOrderTraversal(node.left, callback);
                PostOrderTraversal(node.right, callback);
                callback?.Invoke(node);
            }
        }
    }
}
