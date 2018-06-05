using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMasta.LearnWithCode.DesignPatterns.Creational.FactoryMethod;

namespace PMasta.LearnWithCode.Tests.Unit.DesignPatterns.Creational
{
    /// <summary>
    /// Tests related to the Factory Method pattern.
    /// </summary>
    [TestClass]
    public class FactoryMethodFixture
    {
        [TestMethod]
        public void ConstructFireWorldSucceeds()
        {
            GameWorld world = WorldBuilderService.BuildGameWorld(WorldType.FireWorld);

            Assert.IsTrue(world.Dragon.Name == "Fire Dragon");
            Assert.IsTrue(world.Troll.Name == "Fire Troll");
            Assert.IsTrue(world.Wizard.Name == "Red Wizard");
        }

        [TestMethod]
        public void ConstructIceWorldSucceeds()
        {
            GameWorld world = WorldBuilderService.BuildGameWorld(WorldType.IceWorld);

            Assert.IsTrue(world.Dragon.Name == "Ice Dragon");
            Assert.IsTrue(world.Troll.Name == "Ice Troll");
            Assert.IsTrue(world.Wizard.Name == "White Wizard");
        }

        [TestMethod]
        public void ConstructDarkWorldSucceeds()
        {
            GameWorld world = WorldBuilderService.BuildGameWorld(WorldType.DarkWorld);

            Assert.IsTrue(world.Dragon.Name == "Gold Dragon");
            Assert.IsTrue(world.Troll.Name == "Dark Troll");
            Assert.IsTrue(world.Wizard.Name == "Demon Wizard");
        }
    }
}
