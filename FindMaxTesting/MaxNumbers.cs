using System;

namespace FindMaxTesting
{
    public class MaxNumbers
    {
        public static dynamic CheckData<datatype>(datatype one, datatype two, datatype three) where datatype : IComparable
        {
            if (one.CompareTo(two) > 0 && one.CompareTo(three) > 0)
            {
                return one;
            }
            if (two.CompareTo(one) > 0 && two.CompareTo(three) > 0)
            {
                return two;
            }
            if (three.CompareTo(one) > 0 && three.CompareTo(one) > 0)
            {
                return three;
            }
            return one;
        }
    }
}
