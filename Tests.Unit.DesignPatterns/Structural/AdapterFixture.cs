using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMasta.LearnWithCode.DesignPatterns.Structural.Adapter;

namespace PMasta.LearnWithCode.Tests.Unit.DesignPatterns.Structural
{
    /// <summary>
    /// Tests related to the Adapter design pattern.
    /// </summary>
    [TestClass]
    public class AdapterFixture
    {
        [TestMethod]
        public void AdapterSucceeds()
        {
            TreasureBoxFrameworkService service = new TreasureBoxFrameworkService();
            MyGameTreasureBox myBox = new MyGameTreasureBox();
            FrameworkTreasureBoxAdapter boxAdapter = new FrameworkTreasureBoxAdapter(myBox);

            string loot = service.OpenTreasureBox(boxAdapter);
        }
    }
}
