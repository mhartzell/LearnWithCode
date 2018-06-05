using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMasta.LearnWithCode.DesignPatterns.Creational.Builder;

namespace PMasta.LearnWithCode.Tests.Unit.DesignPatterns.Creational
{
    /// <summary>
    /// Tests related to the Builder pattern.
    /// </summary>
    [TestClass]
    public class BuilderFixture
    {
        [TestMethod]
        public void BuildConvertibleSucceeds()
        {
            IVehicleBuilder builder = VehicleService.GetBuilder(VehicleType.Convertible);
            VehicleService.BuildCar(builder);
            IVehicle vehicle = builder.GetVehicle();

            Assert.IsTrue(vehicle.GetEngine() == "V6");
            Assert.IsTrue(vehicle.GetExhaust() == "Dual exhaust");
            Assert.IsTrue(vehicle.GetInterior() == "Flip top");
            Assert.IsTrue(vehicle.GetSuspension() == "Sports package");
        }

        [TestMethod]
        public void BuildSedanSucceeds()
        {
            IVehicleBuilder builder = VehicleService.GetBuilder(VehicleType.Sedan);
            VehicleService.BuildCar(builder);
            IVehicle vehicle = builder.GetVehicle();

            Assert.IsTrue(vehicle.GetEngine() == "V4");
            Assert.IsTrue(vehicle.GetExhaust() == "Single exhaust");
            Assert.IsTrue(vehicle.GetInterior() == "Sedan interior");
            Assert.IsTrue(vehicle.GetSuspension() == "Standard suspension");
        }

        [TestMethod]
        public void BuildTruckSucceeds()
        {
            IVehicleBuilder builder = VehicleService.GetBuilder(VehicleType.Truck);
            VehicleService.BuildCar(builder);
            IVehicle vehicle = builder.GetVehicle();

            Assert.IsTrue(vehicle.GetEngine() == "V8");
            Assert.IsTrue(vehicle.GetExhaust() == "Dual exhaust");
            Assert.IsTrue(vehicle.GetInterior() == "Extended cab");
            Assert.IsTrue(vehicle.GetSuspension() == "Lift kit");
        }
    }
}
