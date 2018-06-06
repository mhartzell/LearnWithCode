using System;

namespace PMasta.LearnWithCode.DataStructures.Queue
{
    /// <summary>
    /// A concrete implementation of an <see cref="IQueue{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of object stored by the queue.</typeparam>
    public class Queue<T> : IQueue<T>
    {
        private int _itemCount;
        private readonly int _size;
        private T[] _theQueue;

        /// <summary>
        /// Public constructor.
        /// </summary>
        /// <param name="size">The requested size of the queue.</param>
        public Queue(int size)
        {
            if (size == 0)
            {
                throw new ArgumentNullException("size", "You must provide a size for the stack.");
            }

            this._theQueue = new T[size];
            this._size = size;
        }

        public T Dequeue()
        {
            if(this.IsEmpty())
            {
                throw new InvalidOperationException("The queue is empty.");
            }

            T item = this._theQueue[0];
            this._itemCount--;

            for(int i = 0; i < this._itemCount; i++)
            {
                this._theQueue[i] = this._theQueue[i + 1];
            }

            return item;
        }

        public void Empty()
        {
            this._theQueue = new T[this._size];

            this._itemCount = 0;
        }

        public void Enqueue(T item)
        {
            if(this.IsFull())
            {
                throw new InvalidOperationException("The queue is full.");
            }

            this._theQueue[this._itemCount] = item;

            this._itemCount++;
        }

        public bool IsEmpty()
        {
            return this._itemCount == 0;
        }

        public bool IsFull()
        {
            return this._itemCount == this._size;
        }
    }
}
