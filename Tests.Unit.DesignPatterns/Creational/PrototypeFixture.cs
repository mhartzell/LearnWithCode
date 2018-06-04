using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMasta.Learning.DesignPatterns.Creational.Prototype;

namespace PMasta.Learning.Tests.Unit.DesignPatterns.Creational
{
    [TestClass]
    public class PrototypeFixture
    {
        [TestMethod]
        public void PrototypeConstructionSucceeds()
        {
            BasketballPlayerService service = new BasketballPlayerService();

            // Ideally, the client would not know about the concrete types (BasketballPlayer)
            service.RegisterPrototype(new BasketballPlayer { Position = PositionType.Center }, PositionType.Center);
            service.RegisterPrototype(new BasketballPlayer { Position = PositionType.PowerForward }, PositionType.PowerForward);
            service.RegisterPrototype(new BasketballPlayer { Position = PositionType.SmallForward }, PositionType.SmallForward);
            service.RegisterPrototype(new BasketballPlayer { Position = PositionType.ShootingGuard }, PositionType.ShootingGuard);
            service.RegisterPrototype(new BasketballPlayer { Position = PositionType.PointGuard }, PositionType.PointGuard);

            IBasketballPlayer billRussell = service.ConstructBasketballPlayer(PositionType.Center, "Bill Russell");
            IBasketballPlayer pauGasol = service.ConstructBasketballPlayer(PositionType.Center, "Pau Gasol");
            IBasketballPlayer karlMalone = service.ConstructBasketballPlayer(PositionType.PowerForward, "Karl Malone");
            IBasketballPlayer lebronJames = service.ConstructBasketballPlayer(PositionType.SmallForward, "LeBron James");
            IBasketballPlayer michaelJordan = service.ConstructBasketballPlayer(PositionType.ShootingGuard, "Michael Jordan");
            IBasketballPlayer chrisPaul = service.ConstructBasketballPlayer(PositionType.PointGuard, "Chris Paul");

            // If Clone is properly implemented, we should get unique objects for identical prototype requets
            Assert.IsTrue(billRussell.Name == "Bill Russell" && billRussell.Position == PositionType.Center);
            Assert.IsTrue(pauGasol.Name == "Pau Gasol" && pauGasol.Position == PositionType.Center);

            Assert.IsTrue(karlMalone.Name == "Karl Malone" && karlMalone.Position == PositionType.PowerForward);
            Assert.IsTrue(lebronJames.Name == "LeBron James" && lebronJames.Position == PositionType.SmallForward);
            Assert.IsTrue(michaelJordan.Name == "Michael Jordan" && michaelJordan.Position == PositionType.ShootingGuard);
            Assert.IsTrue(chrisPaul.Name == "Chris Paul" && chrisPaul.Position == PositionType.PointGuard);
        }
    }
}
