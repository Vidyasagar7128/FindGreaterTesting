using System;

namespace FindMaxTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum Numbers Between Three Numbers!");
            MaxNumbers maxNumbers = new MaxNumbers();
            maxNumbers.MaxInt();
            maxNumbers.Show();
            maxNumbers.Swaps();
        }
    }
}
