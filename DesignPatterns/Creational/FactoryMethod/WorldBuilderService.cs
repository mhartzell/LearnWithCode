using PMasta.Learning.DesignPatterns.Creational.FactoryMethod.Factories;

namespace PMasta.Learning.DesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// A quick and dirty service to build a game world.
    /// </summary>
    public static class WorldBuilderService
    {
        /// <summary>
        /// Builds a game world based on world type.
        /// </summary>
        /// <param name="worldType">The <see cref="WorldType"/> to build.</param>
        /// <returns>The constructed <see cref="GameWorld"/>.</returns>
        public static GameWorld BuildGameWorld(WorldType worldType)
        {
            IWorldFactory factory = null;

            switch (worldType)
            {
                case WorldType.FireWorld:
                    factory = new FireWorldFactory();
                    break;

                case WorldType.IceWorld:
                    factory = new IceWorldFactory();
                    break;

                case WorldType.DarkWorld:
                    factory = new DarkWorldFactory();
                    break;
            }

            return factory.ConstructWorld();
        }
    }
}
