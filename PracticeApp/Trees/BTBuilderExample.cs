using System;
using Algorithms.Algorithms.Tree;
using Newtonsoft.Json;

namespace PracticeApp.Trees
{
    public class BTBuilderExample
    {
        public void MinimalTreeExample()
        {
            int[] arr = new int[] { 2, 5, 6, 7, 12, 18, 25 };
            BinaryTreeBuilder btBuilder = new BinaryTreeBuilder();
            var tree = btBuilder.MinimalTree(arr);
            Console.WriteLine(JsonConvert.SerializeObject(tree, Formatting.Indented));
            Console.WriteLine();
        }
    }
}
