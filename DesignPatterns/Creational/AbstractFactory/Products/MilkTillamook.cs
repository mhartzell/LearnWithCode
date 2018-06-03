using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.Learning.DesignPatterns.Creational.AbstractFactory.Products
{
    /// <summary>
    /// A concrete implementation of the <see cref="IMilk"/> Abstract Product.
    /// </summary>
    internal class MilkTillamook : IMilk
    {
        public string Brand => "Tillamook";

        public string Description => "Milk";
    }
}
