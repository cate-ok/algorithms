using System;
using PracticeApp.Algorithms.Tree;

namespace PracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algorithms Examples");

            TreeTraversalExample treeTraversalExample = new TreeTraversalExample();
            treeTraversalExample.InOrderTraversalTest();

            BTBuilderExample btExample = new BTBuilderExample();
            btExample.MinimalTreeExample();
        }
    }
}
