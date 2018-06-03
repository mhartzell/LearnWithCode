using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.Learning.DesignPatterns.Creational.AbstractFactory.Products
{
    /// <summary>
    /// A concrete implementation of the <see cref="IEggs"/> Abstract Product.
    /// </summary>
    internal class EggsDarigold : IEggs
    {
        public string Brand => "Darigold";

        public string Description => "Eggs";
    }
}
