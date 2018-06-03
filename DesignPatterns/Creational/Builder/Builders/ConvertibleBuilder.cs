using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.Learning.DesignPatterns.Creational.Builder.Builders
{
    internal class ConvertibleBuilder : VehicleBuilder
    {
        public override void BuildEngine()
        {
            base.BuildEngine();

            this.Vehicle.AddEngine("V6");
        }

        public override void BuildExhaust()
        {
            base.BuildExhaust();

            this.Vehicle.AddExhaust("Dual exhaust");
        }

        public override void BuildInterior()
        {
            base.BuildInterior();

            this.Vehicle.AddInterior("Flip top");
        }

        public override void BuildSuspension()
        {
            base.BuildSuspension();

            this.Vehicle.AddSuspension("Sports package");
        }
    }
}
