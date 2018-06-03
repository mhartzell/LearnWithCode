using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.Learning.DesignPatterns.Creational.AbstractFactory.Products
{
    /// <summary>
    /// A concrete implementation of the <see cref="IButter"/> Abstract Product.
    /// </summary>
    internal class ButterDarigold : IButter
    {
        public string Brand => "Darigold";

        public string Description => "Butter";
    }
}
