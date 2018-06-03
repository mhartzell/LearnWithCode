using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.Learning.DesignPatterns.Creational.AbstractFactory
{
    /// <summary>
    /// A concrete implementation of the <see cref="IEggs"/> Abstract Product.
    /// </summary>
    public class EggsAlpenrose : IEggs
    {
        public string Brand => "Alpenrose";

        public string Description => "Eggs";
    }
}
