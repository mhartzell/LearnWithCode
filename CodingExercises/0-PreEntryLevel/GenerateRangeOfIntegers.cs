using System.Collections.Generic;

namespace PMasta.Learning.CodingExercises._0_PreEntryLevel
{
    /// <summary>
    /// Implement a function named generateRange(min, max, step), which takes three arguments and generates a range of 
    /// integers from min to max, with the step. The first integer is the minimum value, the second is the maximum of the 
    /// range and the third is the step. (min < max)
    /// </summary>
    public class GenerateRangeOfIntegers
    {
        public static int[] GenerateRange(int min, int max, int step)
        {
            List<int> list = new List<int>();

            for (int i = min; i <= max; i += step)
            {
                list.Add(i);
            }

            return list.ToArray();
        }

        // Alternative solution
        //public static int[] GenerateRange(int min, int max, int s) => Enumerable.Range(0, 1 + (max - min) / s).Select(i => min + i * s).ToArray();
    }
}
