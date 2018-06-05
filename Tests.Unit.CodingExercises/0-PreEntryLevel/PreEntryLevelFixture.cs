using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMasta.LearnWithCode.CodingExercises._0_PreEntryLevel;
using System.Linq;

namespace PMasta.LearnWithCode.Tests.Unit.CodingExercises._0_PreEntryLevel
{
    /// <summary>
    /// Tests related to the Pre-Entry Level coding exercises.
    /// </summary>
    [TestClass]
    public class PreEntryLevelFixture
    {
        [TestMethod]
        public void CountLowercaseLettersSucceeds()
        {
            Assert.IsTrue(CountLowercaseLetters.LowercaseCountCheck("abc") == 3);
            Assert.IsTrue(CountLowercaseLetters.LowercaseCountCheck("abcABC123") == 3);
            Assert.IsTrue(CountLowercaseLetters.LowercaseCountCheck("abcABC123!@€£#$%^&*()_-+=}{[]|\':;?/>.<,~\"") == 3);
            Assert.IsTrue(CountLowercaseLetters.LowercaseCountCheck("") == 0);
            Assert.IsTrue(CountLowercaseLetters.LowercaseCountCheck("ABC123!@€£#$%^&*()_-+=}{[]|\':;?/>.<,~\"") == 0);
            Assert.IsTrue(CountLowercaseLetters.LowercaseCountCheck("abcdefghijklmnopqrstuvwxyz") == 26);
        }

        [TestMethod]
        public void GenerateRangeOfIntegersSucceeds()
        {
            int[] result1 = GenerateRangeOfIntegers.GenerateRange(2, 10, 2);
            int[] outcome1 = { 2, 4, 6, 8, 10 };

            int[] result2 = GenerateRangeOfIntegers.GenerateRange(1, 10, 3);
            int[] outcome2 = { 1, 4, 7, 10 };

            Assert.IsTrue(result1.SequenceEqual(outcome1));
        }

        [TestMethod]
        public void RearrangeIntegerToLargestValueSucceeds()
        {
            Assert.IsTrue(RearrangeIntegerToLargestValue.SuperSizeMe(1009876) == 9876100);
            Assert.IsTrue(RearrangeIntegerToLargestValue.SuperSizeMe(123456) == 654321);
            Assert.IsTrue(RearrangeIntegerToLargestValue.SuperSizeMe(105) == 510);
            Assert.IsTrue(RearrangeIntegerToLargestValue.SuperSizeMe(12) == 21);
            Assert.IsTrue(RearrangeIntegerToLargestValue.SuperSizeMe(9) == 9);
        }

        [TestMethod]
        public void RemoveTrailingZeroesSucceeds()
        {
            Assert.IsTrue(RemoveTrailingZeroes.RemoveZeroes(1450) == 145);
            Assert.IsTrue(RemoveTrailingZeroes.RemoveZeroes(960000) == 96);
            Assert.IsTrue(RemoveTrailingZeroes.RemoveZeroes(1050) == 105);
            Assert.IsTrue(RemoveTrailingZeroes.RemoveZeroes(-1050) == -105);
            Assert.IsTrue(RemoveTrailingZeroes.RemoveZeroes(0) == 0);
        }

        [TestMethod]
        public void ValidateUsernameSucceeds()
        {
            // Pass
            Assert.IsTrue(ValidateUsername.Validate("asdda"));
            Assert.IsTrue(ValidateUsername.Validate("____"));
            Assert.IsTrue(ValidateUsername.Validate("p1pp1"));
            Assert.IsTrue(ValidateUsername.Validate("asd43_34"));

            // Fail
            Assert.IsFalse(ValidateUsername.Validate("a"));
            Assert.IsFalse(ValidateUsername.Validate("Hass"));
            Assert.IsFalse(ValidateUsername.Validate("Hasd_12ssssssssssssssasasasasasssasassss"));
            Assert.IsFalse(ValidateUsername.Validate(""));
            Assert.IsFalse(ValidateUsername.Validate("012"));
            Assert.IsFalse(ValidateUsername.Validate("asd43 34"));
        }

        [TestMethod]
        public void VowelsToExclamationMarksSucceeds()
        {
            Assert.IsTrue(VowelsToExclamationMarks.SwapVowels("nvart") == "nv!rt");
            Assert.IsTrue(VowelsToExclamationMarks.SwapVowels("Hi!") == "H!!");
            Assert.IsTrue(VowelsToExclamationMarks.SwapVowels("!Hi! Hi!") == "!H!! H!!");
            Assert.IsTrue(VowelsToExclamationMarks.SwapVowels("aeiou") == "!!!!!");
            Assert.IsTrue(VowelsToExclamationMarks.SwapVowels("ABCDE") == "!BCD!");
        }
    }
}
