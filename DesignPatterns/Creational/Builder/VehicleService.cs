using PMasta.LearnWithCode.DesignPatterns.Creational.Builder.Builders;

namespace PMasta.LearnWithCode.DesignPatterns.Creational.Builder
{
    /// <summary>
    /// A quick and dirty service to abstract the instantiation of a <see cref="IVehicleBuilder"/> and to start
    /// the construction process.
    /// </summary>
    /// <remarks>This service stands in for the Director role in the Builder pattern.  In the described pattern, the client
    /// is responsible for instantiating a new builder, but to me that exposes unnecessary implementation details.  Instead, the client
    /// (unit test) passes in a <see cref="VehicleType"/>, and the service provides the correct concrete builder.</remarks>
    public static class VehicleService
    {
        /// <summary>
        /// Provides an <see cref="IVehicleBuilder"/> appropriate for the requested <see cref="VehicleType"/>.
        /// </summary>
        /// <param name="carType">A <see cref="VehicleType"/>.</param>
        /// <returns>A <see cref="IVehicleBuilder"/>.</returns>
        public static IVehicleBuilder GetBuilder(VehicleType carType)
        {
            IVehicleBuilder builder = null;

            switch (carType)
            {
                case VehicleType.Convertible:
                    builder = new ConvertibleBuilder();
                    break;

                case VehicleType.Sedan:
                    builder = new SedanBuilder();
                    break;

                case VehicleType.Truck:
                    builder = new TruckBuilder();
                    break;
            }

            return builder;
        }

        /// <summary>
        /// Begins construction of a new vehicle.
        /// </summary>
        /// <param name="builder">A <see cref="IVehicleBuilder"/>.</param>
        public static void BuildCar(IVehicleBuilder builder)
        {
            builder.InitializeVehicle();

            builder.BuildEngine();
            builder.BuildExhaust();
            builder.BuildInterior();
            builder.BuildSuspension();
        }
    }
}
