using PMasta.Learning.DesignPatterns.Creational.Builder.Products;
using System;

namespace PMasta.Learning.DesignPatterns.Creational.Builder.Builders
{
    internal abstract class VehicleBuilder : IVehicleBuilder
    {
        protected IVehicle Vehicle;

        public virtual void BuildEngine()
        {
            if (this.Vehicle == null)
            {
                throw new ArgumentNullException("No vehicle was initialized.");
            }
        }

        public virtual void BuildExhaust()
        {
            if (this.Vehicle == null)
            {
                throw new ArgumentNullException("No vehicle was initialized.");
            }
        }

        public virtual void BuildInterior()
        {
            if (this.Vehicle == null)
            {
                throw new ArgumentNullException("No vehicle was initialized.");
            }
        }

        public virtual void BuildSuspension()
        {
            if (this.Vehicle == null)
            {
                throw new ArgumentNullException("No vehicle was initialized.");
            }
        }

        public IVehicle GetVehicle()
        {
            return this.Vehicle;
        }

        public void InitializeVehicle()
        {
            this.Vehicle = new Vehicle();
        }
    }
}
