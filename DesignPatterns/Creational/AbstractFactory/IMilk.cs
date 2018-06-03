using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.Learning.DesignPatterns.Creational.AbstractFactory
{
    /// <summary>
    /// Defines an interface for a milk item.
    /// </summary>
    /// <remarks>This interface defines an Abstract Product that can be produced by an Abstract Factory.</remarks>
    public interface IMilk : IGroceryItem
    {
    }
}
