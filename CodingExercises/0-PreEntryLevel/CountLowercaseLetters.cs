using System.Text.RegularExpressions;

namespace PMasta.Learning.CodingExercises._0_PreEntryLevel
{
    public class CountLowercaseLetters
    {
        public static int LowercaseCountCheck(string input)
        {
            return Regex.Matches(input, "[a-z]").Count;
        }

        // Alternate solutions
        //public static int LowercaseCountCheck(string s) => s.Count(char.IsLower);
        //public static int LowercaseCountCheck(string s) => s.ToCharArray().Where(x => Char.IsLower(x)).Count();
    }
}
