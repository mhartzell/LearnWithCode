using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMasta.LearnWithCode.CodingExercises._1_EntryLevel;

namespace PMasta.LearnWithCode.Tests.Unit.CodingExercises._1_EntryLevel
{
    /// <summary>
    /// Tests related to the Entry Level coding exercises.
    /// </summary>
    [TestClass]
    public class EntryLevelFixture
    {
        [TestMethod]
        public void DoubleAllCharactersSucceeds()
        {
            Assert.IsTrue(DoubleAllCharacters.DoubleChar("String") == "SSttrriinngg");
            Assert.IsTrue(DoubleAllCharacters.DoubleChar("Hello World") == "HHeelllloo  WWoorrlldd");
            Assert.IsTrue(DoubleAllCharacters.DoubleChar("1234!_ ") == "11223344!!__  ");
        }
    }
}
