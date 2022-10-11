using System;

namespace Pattern.TwoPointers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 2, 3, 5, 6, 7, 9, 11, 13 };
            //int k = 9;
            //var pair = PairWithTargetSum.Search(arr, k);
            //Console.WriteLine(pair);

            //int[] arr = { 2, 2, 3, 3, 3, 6, 9, 9 };
            //var duplicatesNum = RemoveDuplicates.Remove(arr);
            //Console.WriteLine(duplicatesNum);

            //int[] arr = { -2, -1, 0, 2, 3 };
            //var squares = SquaringSortedArray.MakeSquares(arr);
            //Console.WriteLine(string.Join(',', squares));

            int[] arr = { -5, 2, -1, -2, 3 };
            var triplets = TripletSumToZero.SearchTriplets(arr);
            
        }
    }
}
