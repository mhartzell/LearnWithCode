using System;

namespace PMasta.LearnWithCode.DataStructures.List
{
    /// <summary>
    /// Implementation of a sorted, linked list.
    /// </summary>
    /// <typeparam name="T">The <see cref="Type"/> of item to store.</typeparam>
    /// <remarks>
    /// This is a doubly-linked list.  Probably a new interface should be built for this list, since the 
    /// GetNextItem() operation, for example, looses a bit of its usefulness.  At the least, this shows how
    /// differently an interface can be implemented and yet still provide the same functionality.
    /// </remarks>
    public class SortedLinkedList<T> : IList<T>
        where T : IComparable
    {
        private LinkedNode<T> _current;
        private int _itemCount = 0;
        private LinkedNode<T> _root;

        /// <summary>
        /// Public constructor.
        /// </summary>
        public SortedLinkedList()
        {

        }

        public void AddItem(T item)
        {
            if (this.Contains(item))
            {
                throw new InvalidOperationException("The list already contains the provided item.");
            }

            // New list
            if (this._itemCount == 0)
            {
                this._root = new LinkedNode<T>(item);
                this._current = this._root;
            }

            // Find the appropriate location
            else
            {
                bool found = false;
                bool tail = false;
                LinkedNode<T> searchCandidate = this._root;

                while (searchCandidate != null && !found && !tail)
                {
                    // Look for next node that has a higher value
                    if (item.CompareTo(searchCandidate.Value) <= 0)
                    {
                        found = true;
                    }

                    else
                    {
                        // If we're at the tail, then stop the search
                        if (searchCandidate.NextNode == null)
                        {
                            tail = true;
                        }

                        // Move on to the next node for another search
                        else
                        {
                            searchCandidate = searchCandidate.NextNode;
                        }
                    }
                }

                LinkedNode<T> newNode = new LinkedNode<T>(item);

                // Adding to the tail
                if (tail)
                {
                    searchCandidate.NextNode = newNode;
                    newNode.PreviousNode = searchCandidate;
                }

                // Add in the middle somewhere
                else
                {
                    // Easily set the references on the new node we constructed
                    newNode.NextNode = searchCandidate;
                    newNode.PreviousNode = searchCandidate.PreviousNode;

                    // If we're at the root, we need to set a new root
                    if (searchCandidate.PreviousNode != null)
                    {
                        searchCandidate.PreviousNode.NextNode = newNode;
                    }

                    // The node we found links back to the new node
                    searchCandidate.PreviousNode = newNode;

                    // If we reset the root, reset the everything list traversal
                    if (newNode.PreviousNode == null)
                    {
                        this._root = newNode;
                        this._current = newNode;
                    }
                }
            }

            this._itemCount++;
        }

        public bool Contains(T item)
        {
            return this.FindNode(item) != null;
        }

        public void Empty()
        {
            this._current = null;
            this._root = null;
        }

        public T GetNextItem()
        {
            T item = default(T);

            // If we're at the root, then just return the root value
            if (this._current.NextNode == null)
            {
                item = this._current.Value;
            }

            // Otherwise, return the current value and enumerate to the next node
            else
            {
                item = this._current.Value;
                this._current = this._current.NextNode;
            }

            return item;
        }

        public bool IsFull()
        {
            // A linked list doesn't have the size limitations of the other, fixed-size lists
            return false;
        }

        public int Length()
        {
            return this._itemCount;
        }

        public void RemoveItem(T item)
        {
            if(!this.Contains(item))
            {
                throw new InvalidOperationException("The list does not contain the item.");
            }

            LinkedNode<T> node = this.FindNode(item);

            if (node != null)
            {
                // If removing the last node, then null up everything
                if (node == this._root)
                {
                    this._current = null;
                    this._root = null;

                    this._itemCount = 0;
                }

                // Otherwise, remove any other node
                else
                {
                    LinkedNode<T> child = node.NextNode;
                    LinkedNode<T> parent = node.PreviousNode;

                    parent.NextNode = child;
                    child.PreviousNode = parent;

                    node.NextNode = null;
                    node.PreviousNode = null;

                    this._itemCount--;
                }
            }
        }

        public void ResetList()
        {
            this._current = this._root;
        }

        private LinkedNode<T> FindNode(T item)
        {
            if(this._itemCount == 0)
            {
                return null;
            }

            bool found = false;
            bool endOfList = false;
            LinkedNode<T> current = this._root;
            LinkedNode<T> foundNode = null;

            while (current != null && !found && !endOfList)
            {
                if (current.Value.CompareTo(item) == 0)
                {
                    found = true;
                    foundNode = current;
                }

                if (current.NextNode == null)
                {
                    endOfList = true;
                }

                current = current.NextNode;
            }

            return foundNode;
        }
    }
}
