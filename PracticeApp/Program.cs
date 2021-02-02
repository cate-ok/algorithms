using System;
using Algorithms.DataStructures.Tree;
using PracticeApp.Algorithms.Tree;

namespace PracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algorithms Examples");

            //TreeTraversalExample treeTraversalExample = new TreeTraversalExample();
            //treeTraversalExample.InOrderTraversalTest();

            //BTBuilderExample btExample = new BTBuilderExample();
            //btExample.MinimalTreeExample();

            TrieCreator trieCreator = new TrieCreator();
            string[] words = new string[]
            {
                "cat",
                "cant",
                "cannot",
                "dog"
            };
            Trie firstTree = trieCreator.CreateTrie(words);

            Console.WriteLine(firstTree.Search("c"));
            Console.WriteLine(firstTree.Search("ca"));
            Console.WriteLine(firstTree.Search("d"));
            Console.WriteLine(firstTree.Search("cat"));
            Console.WriteLine(firstTree.Search("cant"));
            Console.WriteLine(firstTree.Search("canto"));
            Console.WriteLine(firstTree.Search("ocat"));

        }
    }
}
