using PMasta.LearnWithCode.DesignPatterns.Structural.Composite.Components;
using System.Collections.Generic;

namespace PMasta.LearnWithCode.DesignPatterns.Structural.Composite.Leafs
{
    /// <summary>
    /// A concrete <see cref="IInventoryItem"/>.
    /// </summary>
    /// <remarks>
    /// This class fulfills the role of the Leaf object in the Composite pattern.  It does not 
    /// have any children unto itself.
    /// </remarks>
    public class Sword : InventoryItemBase
    {
        public Sword(string name, int durability) : base(name, durability)
        { }

        public override void AddItem(IInventoryItem item)
        {
            // Leave empty?
        }

        public override bool Contains(IInventoryItem item)
        {
            // A leaf has no children
            return false;
        }

        public override ICollection<IInventoryItem> GetContainedItems()
        {
            // No children, so return null
            return null;
        }
    }
}
