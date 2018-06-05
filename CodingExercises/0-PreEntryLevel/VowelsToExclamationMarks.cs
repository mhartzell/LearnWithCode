using System.Text.RegularExpressions;

namespace PMasta.LearnWithCode.CodingExercises._0_PreEntryLevel
{
    /// <summary>
    /// Given a string, replace all vowels in the string with exclamation points, case-insensitive.
    /// </summary>
    public class VowelsToExclamationMarks
    {
        public static string SwapVowels(string input)
        {
            return new Regex("[aeiouAEIOU]").Replace(input, "!");
        }

        // Alternate solution
        //public static string Replace(string s) => Regex.Replace(s, @"[aeiou]", "!", RegexOptions.IgnoreCase);
    }
}
