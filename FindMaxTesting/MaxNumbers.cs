using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxTesting
{
    class MaxNumbers
    {
       public int[] intNums = { 10, 30, 20 };
        public void MaxInt()
        {
            Console.WriteLine("Greater Integer Number");
            ////Sorting it gives top at first position return like  30 20 10
            for (int i = 0; i < intNums.Length - 1; i++)
            {
                for (int j = i + 1; j < intNums.Length; j++)
                {
                    if (intNums[i] < intNums[j])
                    {
                        int temp = intNums[i];
                        intNums[i] = intNums[j];
                        intNums[j] = temp;
                    }
                }
            }
        }
        public int Show()
        {
            Console.WriteLine("First Position : ");
            for (int i = 0; i < intNums.Length; i++)
            {
                Console.WriteLine(intNums[i]);
            }
            return intNums[0];
        }
        public void Swaps()
        {
            /// <summary>
            /// it gives top at Second top position 
            /// </summary>
            Console.WriteLine("Second Position : ");
            if (intNums[0] > intNums[1])
            {
                int temp = intNums[0];
                intNums[0] = intNums[1];
                intNums[1] = temp;
            }
            for (int i = 0; i < intNums.Length; i++)
            {
                Console.WriteLine(intNums[i]);
            }
            /// <summary>
            /// it gives top at Thirt top position 
            /// </summary>
            Console.WriteLine("Third Position : ");
            if (intNums[1] > intNums[2])
            {
                int temp = intNums[1];
                intNums[1] = intNums[2];
                intNums[2] = temp;
            }
            for (int i = 0; i < intNums.Length; i++)
            {
                Console.WriteLine(intNums[i]);
            }
        }
    }
}
