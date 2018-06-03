using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.Learning.DesignPatterns.Creational.AbstractFactory.Products
{
    /// <summary>
    /// A concrete implementation of the <see cref="IEggs"/> Abstract Product.
    /// </summary>
    internal class EggsAlpenrose : IEggs
    {
        public string Brand => "Alpenrose";

        public string Description => "Eggs";
    }
}
