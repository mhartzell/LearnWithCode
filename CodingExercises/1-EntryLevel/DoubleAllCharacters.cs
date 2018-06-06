using System.Linq;

namespace PMasta.LearnWithCode.CodingExercises._1_EntryLevel
{
    /// <summary>
    /// Given a string, return a string in which each character (case-sensitive) is repeated once.
    /// </summary>
    public class DoubleAllCharacters
    {
        public static string DoubleChar(string input) => string.Join("", input.Select((c, output) => c.ToString() + c.ToString()));

        // Alternate solutions
        // public static string DoubleChar(string input) => string.Join("", s.Select(x => "" + x + x));
        // public static string DoubleChar(string input) => s.Aggregate("", (str, c) => str + c + c);
        // public static string DoubleChar(string input) => string.Concat(s.Select(x => $"{x}{x}"));
        // public static string DoubleChar(string input) => string.Join("", s.Select(p=> $"{p}{p}"));
        // public static string DoubleChar(string input) => Regex.Replace(s, ".", "$&$&");
    }
}
