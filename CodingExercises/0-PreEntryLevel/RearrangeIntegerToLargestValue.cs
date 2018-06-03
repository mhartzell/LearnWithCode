using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMasta.Learning.CodingExercises._0_PreEntryLevel
{
    /// <summary>
    /// Problem: Write a function that rearranges an integer into it's largest possible value.
    /// </summary>
    /// <remarks>Taken from https://www.codewars.com/kata/noobcode-01-supersize-me-dot-dot-dot-or-rather-this-integer/csharp </remarks>
    /// <example>
    /// Kata.SuperSize(123456) //654321
    /// Kata.SuperSize(105) // 510
    /// Kata.SuperSize(12) // 21
    /// </example>
    public class RearrangeIntegerToLargestValue
    {
        public static long SuperSizeMe(long value)
        {
            return Convert.ToInt64(
                String.Join(
                    string.Empty, 
                    value.ToString().ToCharArray().OrderByDescending(c => Convert.ToInt64(c)).ToArray()));
        }
    }
}
