using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.Learning.DesignPatterns.Creational.AbstractFactory
{
    /// <summary>
    /// A concrete implementation of the Abstract Factory.
    /// </summary>
    /// <remarks>This factory constructs products in the Darigold family.</remarks>
    public class FactoryDarigold : IGroceryItemFactory
    {
        public IButter ConstructButter()
        {
            return new ButterDarigold();
        }

        public IEggs ConstructEggs()
        {
            return new EggsDarigold();
        }

        public IMilk ConstructMilk()
        {
            return new MilkDarigold();
        }
    }
}
