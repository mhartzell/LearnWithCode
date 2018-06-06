
namespace PMasta.LearnWithCode.DataStructures.Queue
{
    /// <summary>
    /// An interface that defines a Queue data structure.
    /// </summary>
    /// <typeparam name="T">The <see cref="Type"/> to store.</typeparam>
    /// <remarks>
    /// A Queue can be thought of as a variation on a Stack.  It is a first-in, first-out (FIFO) data 
    /// structure.  Items are added at one end and removed from the other.  
    /// </remarks>
    public interface IQueue<T>
    {
        /// <summary>
        /// Removes an item from the queue.
        /// </summary>
        /// <returns>The first item in the queue.</returns>
        T Dequeue();
        
        /// <summary>
        /// Removes all items from the queue.
        /// </summary>
        void Empty();

        /// <summary>
        /// Adds an item to the queue.
        /// </summary>
        /// <param name="item">The item to add.</param>
        void Enqueue(T item);

        /// <summary>
        /// True if the queue is empty of any items.
        /// </summary>
        /// <returns>True if empty.</returns>
        bool IsEmpty();

        /// <summary>
        /// True if the queue has reached max capacity.
        /// </summary>
        /// <returns>True if full.</returns>
        bool IsFull();
    }
}
