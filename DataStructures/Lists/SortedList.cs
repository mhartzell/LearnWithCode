using System;
using System.Collections;
using System.Text;

namespace PMasta.Learning.DataStructures.Lists
{
    /// <summary>
    /// A concrete implementation of a List, with sorting.
    /// </summary>
    /// <remarks>
    /// The sorted list is virtually identical to the unsorted list, aside from its sorting behavior.  Therefore, we can use the 
    /// <see cref="UnsortedList{TType}"/> to do most of the heavy lifting for us, and simply override the methods that require
    /// sorting logic (Add and Remove).
    /// </remarks>
    public class SortedList<TType> : UnsortedList<TType>, IList<TType>
        where TType : IComparable
    {
        public SortedList(int size) : base(size)
        { }

        public override void AddItem(TType item)
        {
            if (this.IsFull())
            {
                throw new InvalidOperationException("The list is full.");
            }

            if (this.Contains(item))
            {
                throw new InvalidOperationException("The list already contains the provided item.");
            }

            int storageIndex = 0;

            // Find the appropriate location
            if (this.Length() > 0)
            {
                for (int i = 0; i < this._list.Length; i++)
                {
                    if (item.CompareTo(this._list[i]) <= 0 || i == this._list.Length - 1)
                    {
                        storageIndex = i;
                        break;
                    }
                }
            }

            // Make space
            for (int i = this.Length() - 1; i >= storageIndex; i--)
            {
                this._list[i + 1] = this._list[i];
            }

            // Insert item
            this._list[storageIndex] = item;

            this._itemCount++;

        }

        public override void RemoveItem(TType item)
        {
            if (!this.Contains(item))
            {
                throw new InvalidOperationException("The item was not found in the list.");
            }

            // Find the appropriate location
            int storageIndex = this.GetIndex(item);

            // Shuffle items back towards the beginning
            for (int i = storageIndex; i < this._itemCount - 1; i++)
            {
                this._list[i] = this._list[i + 1];
            }

            // Reset the last spot in the list
            this._list[this._list.Length - 1] = default(TType);

            this._itemCount--;

        }
    }
}
