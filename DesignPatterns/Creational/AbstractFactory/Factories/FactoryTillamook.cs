using PMasta.LearnWithCode.DesignPatterns.Creational.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.LearnWithCode.DesignPatterns.Creational.AbstractFactory.Factories
{
    /// <summary>
    /// A concrete implementation of the Abstract Factory.
    /// </summary>
    /// <remarks>This factory constructs products in the Tillamook family.</remarks>
    internal class FactoryTillamook : IGroceryItemFactory
    {
        public IButter ConstructButter()
        {
            return new ButterTillamook();
        }

        public IEggs ConstructEggs()
        {
            return new EggsTillamook();
        }

        public IMilk ConstructMilk()
        {
            return new MilkTillamook();
        }
    }
}
