using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.Learning.DesignPatterns.Creational.AbstractFactory
{
    /// <summary>
    /// A concrete implementation of the <see cref="IEggs"/> Abstract Product.
    /// </summary>
    internal class EggsTillamook : IEggs
    {
        public string Brand => "Tillamook";

        public string Description => "Eggs";
    }
}
