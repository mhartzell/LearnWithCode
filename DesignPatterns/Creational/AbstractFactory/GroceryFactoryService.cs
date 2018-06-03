using PMasta.Learning.DesignPatterns.Creational.AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.Learning.DesignPatterns.Creational.AbstractFactory
{
    /// <summary>
    /// A quick and dirty service to provide construction of a concrete factory based on product family.
    /// </summary>
    public static class GroceryFactoryService
    {
        /// <summary>
        /// Constructs a new <see cref="IGroceryItemFactory"/> based on product family.
        /// </summary>
        /// <param name="family">The <see cref="GroceryProductFamily"/> to construct a factory for.</param>
        /// <returns>An <see cref="IGroceryItemFactory"/>.</returns>
        public static IGroceryItemFactory CreateGroceryItemFactory(GroceryProductFamily family)
        {
            switch (family)
            {
                case GroceryProductFamily.Alpenrose:
                    return new FactoryAlpenrose();

                case GroceryProductFamily.Darigold:
                    return new FactoryDarigold();

                case GroceryProductFamily.Tillamook:
                    return new FactoryTillamook();

                default:
                    throw new InvalidOperationException("No factory was found.");
            }
        }
    }
}
