using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMasta.LearnWithCode.CodingExercises._2_MidLevel
{
    public class SumRangeOfNumbers
    {
        public static int SumRange(int[] range)
        {
            int lower = range[0] > range[1] ? range[1] : range[0];
            int upper = range[0] > range[0] ? range[0] : range[1];

            return Enumerable.Range(lower, (upper - lower) + 1).Sum();
        }
    }
}
