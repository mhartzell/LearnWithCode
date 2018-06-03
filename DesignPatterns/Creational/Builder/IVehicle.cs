using System;

namespace PMasta.Learning.DesignPatterns.Creational.Builder
{
    /// <summary>
    /// Defines an interface for a vehicle.
    /// </summary>
    /// <remarks>
    /// In the Builder pattern, this interface serves as the role of the Product.
    /// </remarks>
    public interface IVehicle
    {
        /// <summary>
        /// Adds an engine to a vehicle.
        /// </summary>
        /// <param name="engineType">The type of engine to add.</param>
        void AddEngine(string engineType);

        /// <summary>
        /// Adds an exhaust system to a vehicle.
        /// </summary>
        /// <param name="exhaustType">The type of exhaust to add.</param>
        void AddExhaust(string exhaustType);

        /// <summary>
        /// Adds an interior to a vehicle.
        /// </summary>
        /// <param name="interiorType">The type of interior to add.</param>
        void AddInterior(string interiorType);

        /// <summary>
        /// Adds a suspension system to a vehicle.
        /// </summary>
        /// <param name="suspensionType">The type of suspension to add.</param>
        void AddSuspension(string suspensionType);

        /// <summary>
        /// Retrieves the vehicle engine.
        /// </summary>
        /// <returns>A <see cref="String"/>.</returns>
        string GetEngine();

        /// <summary>
        /// Retrieves the vehicle exhaust.
        /// </summary>
        /// <returns>A <see cref="String"/>.</returns>
        string GetExhaust();

        /// <summary>
        /// Retrieves the vehicle interior.
        /// </summary>
        /// <returns>A <see cref="String"/>.</returns>
        string GetInterior();

        /// <summary>
        /// Retrieves the vehicle suspension.
        /// </summary>
        /// <returns>A <see cref="String"/>.</returns>
        string GetSuspension();
    }
}
