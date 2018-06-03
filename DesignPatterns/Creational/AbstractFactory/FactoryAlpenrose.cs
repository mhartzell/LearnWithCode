using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.Learning.DesignPatterns.Creational.AbstractFactory
{
    /// <summary>
    /// A concrete implementation of the Abstract Factory.
    /// </summary>
    /// <remarks>This factory constructs products in the Alepnrose family.</remarks>
    public class FactoryAlpenrose : IGroceryItemFactory
    {
        public IButter ConstructButter()
        {
            return new ButterAlpenrose();
        }

        public IEggs ConstructEggs()
        {
            return new EggsAlpenrose();
        }

        public IMilk ConstructMilk()
        {
            return new MilkAlpenrose();
        }
    }
}
