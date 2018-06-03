using System;

namespace PMasta.Learning.DataStructures.UnsortedList
{
    /// <summary>
    /// A concrete implementation of an unsorted list.
    /// </summary>
    /// <typeparam name="TType">The type of object to store in the list.</typeparam>
    public class UnsortedList<TType> : IList<TType>
    {
        private int _itemCount = 0;
        private int _iteratorIndex = 0;
        private readonly TType[] _list;

        public UnsortedList(int size)
        {
            if(size == 0)
            {
                throw new InvalidOperationException("You must provide a size greater than zero.");
            }

            this._list = new TType[size];
        }

        public void AddItem(TType item)
        {
            if(this.IsFull())
            {
                throw new InvalidOperationException("The list is full.");
            }

            if(this.Contains(item))
            {
                throw new InvalidOperationException("The list already contains the provided item.");
            }

            this._list[this._itemCount] = item;

            this._itemCount++;
        }

        public bool Contains(TType item)
        {
            bool result = false;

            for (int i = 0; i < this._list.Length; i++)
            {
                if (this._list[i].Equals(item))
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public void Empty()
        {
            for (int i = 0; i < this._list.Length; i++)
            {
                this._list[i] = default(TType);
            }

            this._itemCount = 0;
        }

        public TType GetNextItem()
        {
            TType item = this._list[this._iteratorIndex];

            if (this._iteratorIndex < this._list.Length - 1)
            {
                this._iteratorIndex++;
            }

            return item;
        }

        public bool IsFull()
        {
            return this._list.Length == this._itemCount;
        }

        public int Length()
        {
            return _itemCount;
        }

        public void RemoveItem(TType item)
        {
            if(!this.Contains(item))
            {
                throw new InvalidOperationException("The item was not found in the list.");
            }

            int index = this.GetIndex(item);

            // Shuffle items back towards the beginning
            for(int i = index; i < this._itemCount - 1; i++)
            {
                this._list[i] = this._list[i + 1];
            }

            // Reset the last spot in the list
            this._list[this._list.Length - 1] = default(TType);

            this._itemCount--;
        }

        public void ResetList()
        {
            this._iteratorIndex = 0;
        }

        private int GetIndex(TType item)
        {
            int index = 0;

            for (int i = 0; i < this._list.Length; i++)
            {
                if (this._list[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
    }
}
