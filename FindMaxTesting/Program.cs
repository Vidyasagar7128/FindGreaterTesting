using System;

namespace FindMaxTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum Numbers Between Three Numbers!");
            MaxNumbers maxNumbers = new MaxNumbers();
            Console.WriteLine(maxNumbers.DoubleSwaps(10.5f, 30.2f, 20.9f));
        }
    }
}
