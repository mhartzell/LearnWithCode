namespace PMasta.Learning.DesignPatterns.Creational.Builder.Builders
{
    /// <summary>
    /// Concrete Builder implementation.
    /// </summary>
    internal class TruckBuilder : VehicleBuilder
    {
        public override void BuildEngine()
        {
            base.BuildEngine();

            this.Vehicle.AddEngine("V8");
        }

        public override void BuildExhaust()
        {
            base.BuildExhaust();

            this.Vehicle.AddExhaust("Dual exhaust");
        }

        public override void BuildInterior()
        {
            base.BuildInterior();

            this.Vehicle.AddInterior("Extended cab");
        }

        public override void BuildSuspension()
        {
            base.BuildSuspension();

            this.Vehicle.AddSuspension("Lift kit");
        }
    }
}
