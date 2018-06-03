using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.Learning.DesignPatterns.Creational.AbstractFactory
{
    /// <summary>
    /// A concrete implementation of the <see cref="IButter"/> Abstract Product.
    /// </summary>
    internal class ButterAlpenrose : IButter
    {
        public string Brand => "Alpenrose";

        public string Description => "Butter";
    }
}
