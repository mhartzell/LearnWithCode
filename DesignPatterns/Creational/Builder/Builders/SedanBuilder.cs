namespace PMasta.LearnWithCode.DesignPatterns.Creational.Builder.Builders
{
    /// <summary>
    /// Concrete Builder implementation.
    /// </summary>
    internal class SedanBuilder : VehicleBuilder
    {
        public override void BuildEngine()
        {
            base.BuildEngine();

            this.Vehicle.AddEngine("V4");
        }

        public override void BuildExhaust()
        {
            base.BuildExhaust();

            this.Vehicle.AddExhaust("Single exhaust");
        }

        public override void BuildInterior()
        {
            base.BuildInterior();

            this.Vehicle.AddInterior("Sedan interior");
        }

        public override void BuildSuspension()
        {
            base.BuildSuspension();

            this.Vehicle.AddSuspension("Standard suspension");
        }
    }
}
