using PMasta.LearnWithCode.DesignPatterns.Structural.Composite.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.LearnWithCode.DesignPatterns.Structural.Composite.Composites
{
    /// <summary>
    /// A concrete <see cref="IInventoryItem"/>.
    /// </summary>
    /// <remarks>
    /// This class fulfills the role of the Composite in the Composite pattern.  It is an 
    /// inventory item unto itself, but it also is a composite object and has children of its own.
    /// </remarks>
    public class InventoryContainer : InventoryItemBase
    {
        // This composite simply stores things in a simple list
        private IList<IInventoryItem> _children = new List<IInventoryItem>();

        public InventoryContainer(string name, int durability) : base(name, durability)
        { }

        public override void AddItem(IInventoryItem item)
        {
            item.Parent = this;

            this._children.Add(item);
        }

        public override bool Contains(IInventoryItem item)
        {
            return this._children.Contains(item);
        }

        public override ICollection<IInventoryItem> GetContainedItems()
        {
            return this._children;
        }
    }
}
