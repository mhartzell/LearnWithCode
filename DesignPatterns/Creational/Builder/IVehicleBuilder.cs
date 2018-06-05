namespace PMasta.LearnWithCode.DesignPatterns.Creational.Builder
{
    /// <summary>
    /// An interface defining the Builder object creational pattern.
    /// </summary>
    /// <remarks>
    /// <para>The Builder pattern separates the construction of a complex object from its
    /// representation so that the same construction process can create different representations.
    /// The Builder interface specifies the operations for creating the indiviudal parts of a Product.</para>
    /// </remarks>
    public interface IVehicleBuilder
    {
        /// <summary>
        /// Builds a vehicle engine.
        /// </summary>
        void BuildEngine();

        /// <summary>
        /// Builds a vehicle exhaust system.
        /// </summary>
        void BuildExhaust();

        /// <summary>
        /// Builds a vehicle interior.
        /// </summary>
        void BuildInterior();

        /// <summary>
        /// Builds a vehicle suspension system.
        /// </summary>
        void BuildSuspension();

        /// <summary>
        /// Retrieves a previously built vehicle.
        /// </summary>
        /// <returns></returns>
        IVehicle GetVehicle();

        /// <summary>
        /// Starts the build process for a vehicle.
        /// </summary>
        void InitializeVehicle();
    }
}
