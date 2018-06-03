using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.Learning.DesignPatterns.Creational.AbstractFactory
{
    /// <summary>
    /// A concrete implementation of the Abstract Factory.
    /// </summary>
    /// <remarks>This factory constructs products in the Tillamook family.</remarks>
    public class FactoryTillamook : IGroceryItemFactory
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
