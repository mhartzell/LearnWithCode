using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMasta.Learning.CodingExercises._0_PreEntryLevel;
using System.Linq;

namespace PMasta.Learning.Tests.Unit.CodingExercises._0_PreEntryLevel
{
    /// <summary>
    /// Tests related to the Pre-Entry Level coding exercises.
    /// </summary>
    [TestClass]
    public class PreEntryLevelFixture
    {
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
    }
}
