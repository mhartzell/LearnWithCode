using System.Collections.Generic;

namespace PMasta.LearnWithCode.DesignPatterns.Structural.Composite.Components
{
    /// <summary>
    /// Abstract implementation of <see cref="IInventoryItem"/>.
    /// </summary>
    /// <remarks>
    /// Along with the interface, this class fulfills the role of the Component.
    /// </remarks>
    public abstract class InventoryItemBase : IInventoryItem
    {
        protected InventoryItemBase(string name, int durability)
        {
            this.Durability = durability;
            this.Name = name;
        }

        public int Durability { get; set; }

        public string Name { get; set; }

        public IInventoryItem Parent { get; set; }

        // Subclasses will define how to manage children
        public abstract void AddItem(IInventoryItem item);

        public abstract bool Contains(IInventoryItem item);

        public abstract ICollection<IInventoryItem> GetContainedItems();
    }
}
