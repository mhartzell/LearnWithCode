using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.Learning.DesignPatterns.Creational.AbstractFactory
{
    /// <summary>
    /// A concrete implementation of the <see cref="IMilk"/> Abstract Product.
    /// </summary>
    public class MilkAlpenrose : IMilk
    {
        public string Brand => "Alpenrose";

        public string Description => "Milk";
    }
}
