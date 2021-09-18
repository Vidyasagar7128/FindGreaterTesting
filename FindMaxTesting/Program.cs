using System;

namespace FindMaxTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum Numbers Between Three Numbers!");
            MaxNumbers maxNumbers = new MaxNumbers();
            Console.WriteLine(maxNumbers.IntSwaps(10, 30, 20));
        }
    }
}
