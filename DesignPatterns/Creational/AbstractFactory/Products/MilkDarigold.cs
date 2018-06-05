using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.LearnWithCode.DesignPatterns.Creational.AbstractFactory.Products
{
    /// <summary>
    /// A concrete implementation of the <see cref="IMilk"/> Abstract Product.
    /// </summary>
    internal class MilkDarigold : IMilk
    {
        public string Brand => "Darigold";

        public string Description => "Milk";
    }
}
