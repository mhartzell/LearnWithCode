namespace PMasta.LearnWithCode.DataStructures.List
{
    /// <summary>
    /// Defines an interface for a basic List data structure.
    /// </summary>
    /// <typeparam name="T">The type of objects to be stored in the list.</typeparam>
    /// <remarks>
    /// A list is a homogenous collection of elements, with a linear relationship between those elements.  
    /// </remarks>
    public interface IList<T>
    {
        /// <summary>
        /// Adds an item to the list.
        /// </summary>
        /// <param name="item">The item to add.</param>
        void AddItem(T item);

        /// <summary>
        /// True if the list contains the item specified.
        /// </summary>
        /// <param name="item">The item to search for.</param>
        /// <returns>True if found.</returns>
        bool Contains(T item);

        /// <summary>
        /// Empties the list of all items.
        /// </summary>
        void Empty();

        /// <summary>
        /// Gets in the next item in the list.
        /// </summary>
        /// <returns></returns>
        T GetNextItem();

        /// <summary>
        /// True if the list is full.
        /// </summary>
        /// <returns></returns>
        bool IsFull();
        
        /// <summary>
        /// The current length of the list.
        /// </summary>
        /// <returns></returns>
        int Length();

        /// <summary>
        /// Removes an item from the list.
        /// </summary>
        /// <param name="item">The item to remove.</param>
        void RemoveItem(T item);

        /// <summary>
        /// Sets the list iterator to the beginning of the list.
        /// </summary>
        void ResetList();
    }
}
