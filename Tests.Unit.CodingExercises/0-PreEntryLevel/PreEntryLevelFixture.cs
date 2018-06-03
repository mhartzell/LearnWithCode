using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMasta.Learning.CodingExercises._0_PreEntryLevel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.Learning.Tests.Unit.CodingExercises._0_PreEntryLevel
{
    /// <summary>
    /// Tests related to the Pre-Entry Level coding exercises.
    /// </summary>
    [TestClass]
    public class PreEntryLevelFixture
    {
        [TestMethod]
        public void RearrangeIntegerToLargestValueSucceeds()
        {
            Assert.IsTrue(RearrangeIntegerToLargestValue.SuperSizeMe(1009876) == 9876100);
            Assert.IsTrue(RearrangeIntegerToLargestValue.SuperSizeMe(123456) == 654321);
            Assert.IsTrue(RearrangeIntegerToLargestValue.SuperSizeMe(105) == 510);
            Assert.IsTrue(RearrangeIntegerToLargestValue.SuperSizeMe(12) == 21);
            Assert.IsTrue(RearrangeIntegerToLargestValue.SuperSizeMe(9) == 9);
        }
    }
}
