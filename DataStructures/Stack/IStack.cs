namespace PMasta.LearnWithCode.DataStructures.Stack
{
    /// <summary>
    /// Defines an interface for a Stack data structure.
    /// </summary>
    /// <typeparam name="T">The type stored by the stack.</typeparam>
    /// <remarks>
    /// A stack is an ordered group of homogeneous elements, where adding or removal of items can only take place
    /// at the top of the stack. A stack is considered "ordered" because elements occur in a particular sequence 
    /// according to how long they've been in the stack.  The last element add is the first to be removed from a 
    /// stack; it is a last-in, first-out (LIFO) data structure.
    /// </remarks>
    public interface IStack<T>
    {
        /// <summary>
        /// Empties the stack of all elements.
        /// </summary>
        void Empty();

        /// <summary>
        /// True if the stack is empty of any elements.
        /// </summary>
        /// <returns>True if empty.</returns>
        bool IsEmpty();

        /// <summary>
        /// True if the stack has reached max capacity.
        /// </summary>
        /// <returns>True if full.</returns>
        bool IsFull();

        /// <summary>
        /// Pushes a new item onto the top of the stack.
        /// </summary>
        /// <param name="item">The item to push.</param>
        void Push(T item);

        /// <summary>
        /// Pops the top item off of the stack.
        /// </summary>
        /// <returns>The top item.</returns>
        T Pop();

        /// <summary>
        /// Returns a copy of the top-most item of the stack.
        /// </summary>
        /// <returns>The top item.</returns>
        T Top();
    }
}
