using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxTesting
{
    class MaxNumbers
    {
        public int IntSwaps(int one,int two, int three)
        {
            if(one.CompareTo(two) > 0 && one.CompareTo(three) > 0 ||
               one.CompareTo(two) >= 0 && one.CompareTo(three) > 0 ||
               one.CompareTo(two) > 0 && one.CompareTo(three) >= 0)
            {
                return one;
            }
            if (two.CompareTo(one) > 0 && two.CompareTo(three) > 0 ||
               two.CompareTo(one) >= 0 && two.CompareTo(three) > 0 ||
               two.CompareTo(one) > 0 && two.CompareTo(three) >= 0)
            {
                return two;
            }
            if (three.CompareTo(one) > 0 && three.CompareTo(two) > 0 ||
               three.CompareTo(one) >= 0 && three.CompareTo(two) > 0 ||
               three.CompareTo(one) > 0 && three.CompareTo(two) >= 0)
            {
                return three;
            }
            return one;
        }
    }
}
