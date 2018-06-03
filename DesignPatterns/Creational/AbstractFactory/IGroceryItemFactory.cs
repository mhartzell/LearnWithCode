using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.Learning.DesignPatterns.Creational.AbstractFactory
{
    /// <summary>
    /// A interface defining the Abstract Factory object creational pattern.
    /// </summary>
    /// <remarks>
    /// <para>The Abstract Factory pattern provides an interface for creating families of related or dependent
    /// objects without specifying their concrete classes.  The factory has methods for returning instances of 
    /// certain products (in this case, grocery items), but consuming clients are not aware of of the concrete
    /// classes they are using.</para>
    /// <para>Do note that this implementation uses an interface to declare the factory.  The "Abstract" in the 
    /// Abstract Factory pattern has nothing to with the literal abstract keyword in C#, but rather describes the 
    /// concept that the factory abstracts the process of product creation.  An abstract class may be required, 
    /// depending on needs.</para>
    /// </remarks>
    public interface IGroceryItemFactory
    {
        /// <summary>
        /// Constructs a new object of type IButter.
        /// </summary>
        /// <returns>An <see cref="IButter"/>.</returns>
        IButter ConstructButter();

        /// <summary>
        /// Constructs a new object of type IEggs.
        /// </summary>
        /// <returns>An <see cref="IEggs"/>.</returns>
        IEggs ConstructEggs();

        /// <summary>
        /// Constructs a new object of type IMilk.
        /// </summary>
        /// <returns>An <see cref="IMilk"/>.</returns>
        IMilk ConstructMilk();
    }
}
