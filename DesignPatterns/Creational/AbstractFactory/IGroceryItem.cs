using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.LearnWithCode.DesignPatterns.Creational.AbstractFactory
{
    /// <summary>
    /// Definies an interface for a generic grocery item.
    /// </summary>
    public interface IGroceryItem
    {
        /// <summary>
        /// The item's brand.
        /// </summary>
        string Brand { get; }

        /// <summary>
        /// The item's description.
        /// </summary>
        string Description { get; }
    }
}
