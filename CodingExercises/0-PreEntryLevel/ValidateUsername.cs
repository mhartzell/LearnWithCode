using System.Text.RegularExpressions;

namespace PMasta.LearnWithCode.CodingExercises._0_PreEntryLevel
{
    /// <summary>
    /// Given a username as a string, validate its correctness given the following constraints:
    /// - Allowed characters - lowercase letters, numbers, underscore
    /// - Length between 4 and 16 characters inclusive
    /// </summary>
    public class ValidateUsername
    {
        public static bool Validate(string username) => username.Length >= 4 && username.Length <= 16 && Regex.Matches(username, "[^a-z0-9_]").Count == 0;

        // Alternate solutions
        // public static bool ValidateUsr(string Username) => Regex.IsMatch(Username, "^[a-z0-9_]{4,16}$");
    }
}
