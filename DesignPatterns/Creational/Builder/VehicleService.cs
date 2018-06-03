using PMasta.Learning.DesignPatterns.Creational.Builder.Builders;

namespace PMasta.Learning.DesignPatterns.Creational.Builder
{
    public static class VehicleService
    {
        public static IVehicleBuilder GetBuilder(CarType carType)
        {
            IVehicleBuilder builder = null;

            switch (carType)
            {
                case CarType.Convertible:
                    builder = new ConvertibleBuilder();
                    break;

                case CarType.Sedan:
                    builder = new SedanBuilder();
                    break;

                case CarType.Truck:
                    builder = new TruckBuilder();
                    break;
            }

            return builder;
        }

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
