using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.Learning.DesignPatterns.Creational.AbstractFactory
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
