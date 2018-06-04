using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.Learning.CodingExercises._0_PreEntryLevel
{
    /// <summary>
    /// Get rid of any / all trailing zeros from a number.
    /// </summary>
    public class RemoveTrailingZeroes
    {
        public static long RemoveZeroes(long number)
        {
            return number == 0 ? number : long.Parse(number.ToString().TrimEnd('0'));
        }
    }
}
