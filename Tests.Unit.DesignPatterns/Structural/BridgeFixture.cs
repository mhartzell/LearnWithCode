using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMasta.LearnWithCode.DesignPatterns.Structural.Bridge;
using PMasta.LearnWithCode.DesignPatterns.Structural.Bridge.Gamers;

namespace PMasta.LearnWithCode.Tests.Unit.DesignPatterns.Structural
{
    /// <summary>
    /// Tests related to the Bridge design pattern.
    /// </summary>
    [TestClass]
    public class BridgeFixture
    {
        [TestMethod]
        public void PlaystationSucceeds()
        {
            IGamer gamer = new Gamer(Platform.Playstation4);

            Assert.IsTrue(gamer.GetName() == "Playstation Gamer");
        }

        [TestMethod]
        public void SteamSucceeds()
        {
            IGamer gamer = new Gamer(Platform.Steam);

            Assert.IsTrue(gamer.GetName() == "Steam Gamer");
        }

        [TestMethod]
        public void XBoxSucceeds()
        {
            IGamer gamer = new Gamer(Platform.XBox);

            Assert.IsTrue(gamer.GetName() == "XBox Gamer");
        }
    }
}
