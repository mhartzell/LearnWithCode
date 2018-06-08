using PMasta.LearnWithCode.DesignPatterns.Structural.Composite.Components;
using System.Collections.Generic;
using System.Linq;

namespace PMasta.LearnWithCode.DesignPatterns.Structural.Composite.Composites
{
    public class UniqueInventoryContainer : InventoryItemBase
    {
        // This composite stores things in a dictionary to prevent duplicate item
        private IDictionary<string, IInventoryItem> _children = new Dictionary<string, IInventoryItem>();

        public UniqueInventoryContainer(string name, int durability) : base(name, durability)
        { }

        public override void AddItem(IInventoryItem item)
        {
            item.Parent = this;

            this._children.Add(item.Name, item);
        }

        public override bool Contains(IInventoryItem item)
        {
            return this._children.ContainsKey(item.Name);
        }

        public override ICollection<IInventoryItem> GetContainedItems()
        {
            return this._children.Values.ToList();
        }
    }
}
