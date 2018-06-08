using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMasta.LearnWithCode.CodingExercises._2_MidLevel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.LearnWithCode.Tests.Unit.CodingExercises._2_MidLevel
{
    [TestClass]
    public class SumRangeOfNumbersFixture
    {
        [TestMethod]
        public void SumRangeSucceeds()
        {
            Assert.IsTrue(SumRangeOfNumbers.SumRange(new int[] { 1, 5 }) == 15);
            Assert.IsTrue(SumRangeOfNumbers.SumRange(new int[] { 3, 7 }) == 25);
        }
    }
}
