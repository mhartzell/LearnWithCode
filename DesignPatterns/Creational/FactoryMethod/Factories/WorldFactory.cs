using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.Learning.DesignPatterns.Creational.FactoryMethod.Factories
{
    /// <summary>
    /// A abstract implemention of the <see cref="IWorldFactory"/>.  
    /// </summary>
    /// <remarks>
    /// The Factory Method is declared as abstract and must be overriden by inheriting subclasses.  It could 
    /// also provide a default implementation if so desired.
    /// </remarks>
    internal abstract class WorldFactory : IWorldFactory
    {
        public abstract GameWorld ConstructWorld();
    }
}
