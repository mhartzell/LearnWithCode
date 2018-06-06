using System;

namespace PMasta.LearnWithCode.DataStructures.Stack
{
    /// <summary>
    /// A concrete implementation of an <see cref="IStack{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of object stored by the stack.</typeparam>
    public class Stack<T> : IStack<T>
    {
        private int _currentIndex = 0;
        private T[] _theStack;
        private readonly int _size = 0;

        /// <summary>
        /// Public constructor.
        /// </summary>
        /// <param name="size">The requested size of the array.</param>
        public Stack(int size)
        {
            this._size = size;
            this._theStack = new T[this._size];
        }

        public void Empty()
        {
            this._theStack = new T[this._size];
            this._currentIndex = 0;
        }

        public bool IsEmpty()
        {
            return this._currentIndex == 0;
        }

        public bool IsFull()
        {
            return this._currentIndex == this._theStack.Length;
        }

        public T Pop()
        {
            if(this.IsEmpty())
            {
                throw new InvalidOperationException("The stack is currently empty.");
            }
                
            // Backtrack to the current item
            _currentIndex--;

            // Grab the current item
            T item = this._theStack[this._currentIndex];

            // Erase the current item
            this._theStack[this._currentIndex] = default(T);

            return item;
        }

        public void Push(T item)
        {
            if(this.IsFull())
            {
                throw new InvalidOperationException("The stack is already at max capacity.");
            }

            // Store the current item
            this._theStack[this._currentIndex] = item;

            // Move to the next open slot
            _currentIndex++;
        }

        public T Top()
        {
            if(this.IsEmpty())
            {
                throw new InvalidOperationException("The stack is currently empty.");
            }

            return this._theStack[this._currentIndex - 1];
        }
    }
}
