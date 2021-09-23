using System;

namespace FindMaxTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum With Testing!");
            int intNum = MaxNumbers.CheckData<int>(10,30,20);
            float floatNum = MaxNumbers.CheckData<float>(10.2f,30.5f,20.9f);
            string str = MaxNumbers.CheckData<string>("Apple","Peach","Banana");
            Console.WriteLine($"Int : {intNum}, Float : {floatNum}, String : {str}");
        }
    }
}
