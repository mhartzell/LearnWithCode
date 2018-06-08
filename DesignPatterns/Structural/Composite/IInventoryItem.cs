using System.Collections.Generic;

namespace PMasta.LearnWithCode.DesignPatterns.Structural.Composite
{
    /// <summary>
    /// An interface defining a generic player inventory item.
    /// </summary>
    /// <remarks>
    /// This interface represents the role of Component in the Composite pattern.  It is the generic
    /// composition object.
    /// </remarks>
    public interface IInventoryItem
    {
        // Interface for objects in the Composite
        int Durability { get; set; }

        string Name { get; set; }

        // Interface for accessing and managing child components
        void AddItem(IInventoryItem item);

        bool Contains(IInventoryItem item);

        ICollection<IInventoryItem> GetContainedItems();

        // Interface for accessing a component's parent
        IInventoryItem Parent { get; set; }
    }
}
