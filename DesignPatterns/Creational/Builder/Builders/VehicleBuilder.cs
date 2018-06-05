using PMasta.LearnWithCode.DesignPatterns.Creational.Builder.Products;
using System;

namespace PMasta.LearnWithCode.DesignPatterns.Creational.Builder.Builders
{
    /// <summary>
    /// An abstract vehicle builder.
    /// </summary>
    /// <remarks>
    /// This abstract base class exists solely to make life easier in the subclasses.  Null reference checking can happen here,
    /// instead of being repeated in every subclass, as well as the standard methods for starting construction on the vehicle
    /// and retrieving it.
    /// </remarks>
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
