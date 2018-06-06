using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMasta.LearnWithCode.DataStructures.List;
using System;

namespace PMasta.LearnWithCode.Tests.Unit.DataStructures.List
{
    /// <summary>
    /// Tests related to the Unsorted List.
    /// </summary>
    [TestClass]
    public class UnsortedListFixture
    {
        #region Create List

        [TestMethod]
        public void ConstructListSucceeds()
        {
            IList<int> list = new UnsortedList<int>(10);

            Assert.IsNotNull(list);
            Assert.IsTrue(list.Length() == 0);
        }

        [TestMethod]
        public void ConstructListFailsWithZeroSize()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new UnsortedList<int>(0));
        }

        #endregion

        #region Add Item

        [TestMethod]
        public void AddItemSucceeds()
        {
            IList<int> list = new UnsortedList<int>(10);

            list.AddItem(16);

            Assert.IsTrue(list.Contains(16));
        }

        [TestMethod]
        public void AddItemFailsWithDuplicateItem()
        {
            IList<int> list = new UnsortedList<int>(10);

            list.AddItem(16);

            Assert.ThrowsException<InvalidOperationException>(() => list.AddItem(16));
        }

        [TestMethod]
        public void AddItemFailsWithFullList()
        {
            IList<int> list = new UnsortedList<int>(3);

            list.AddItem(3);
            list.AddItem(16);
            list.AddItem(2);

            Assert.ThrowsException<InvalidOperationException>(() => list.AddItem(23));
        }

        #endregion

        #region Empty List

        [TestMethod]
        public void EmptyListSucceeds()
        {
            IList<int> list = new UnsortedList<int>(10);

            list.AddItem(16);

            Assert.IsTrue(list.Contains(16));

            list.Empty();

            Assert.IsFalse(list.Contains(16));
        }

        #endregion

        #region Get Next Item

        [TestMethod]
        public void GetNextItemSucceeds()
        {
            IList<int> list = new UnsortedList<int>(10);

            list.AddItem(16);
            list.AddItem(3);
            list.AddItem(11);

            Assert.IsTrue(list.GetNextItem() == 16);
            Assert.IsTrue(list.GetNextItem() == 3);
            Assert.IsTrue(list.GetNextItem() == 11);
        }

        [TestMethod]
        public void GetNextItemSucceedsAfterReset()
        {
            IList<int> list = new UnsortedList<int>(10);

            list.AddItem(16);
            list.AddItem(3);
            list.AddItem(11);

            Assert.IsTrue(list.GetNextItem() == 16);
            Assert.IsTrue(list.GetNextItem() == 3);

            list.ResetList();

            Assert.IsTrue(list.GetNextItem() == 16);
            Assert.IsTrue(list.GetNextItem() == 3);
            Assert.IsTrue(list.GetNextItem() == 11);
        }

        #endregion

        #region List Full

        [TestMethod]
        public void ListIsFullSucceeds()
        {
            IList<int> list = new UnsortedList<int>(3);

            list.AddItem(16);
            list.AddItem(3);
            list.AddItem(11);

            Assert.IsTrue(list.IsFull());
        }

        [TestMethod]
        public void ListIsFullFails()
        {
            IList<int> list = new UnsortedList<int>(10);

            list.AddItem(16);
            list.AddItem(3);
            list.AddItem(11);

            Assert.IsFalse(list.IsFull());
        }

        #endregion

        #region Remove Item

        [TestMethod]
        public void RemoveItemSucceeds()
        {
            IList<int> list = new UnsortedList<int>(5);

            list.AddItem(16);
            list.AddItem(3);
            list.AddItem(11);
            list.AddItem(4);
            list.AddItem(25);

            Assert.IsTrue(list.Length() == 5);

            list.RemoveItem(11);

            Assert.IsTrue(list.Length() == 4);
            Assert.IsTrue(list.GetNextItem() == 16);
            Assert.IsTrue(list.GetNextItem() == 3);
            Assert.IsTrue(list.GetNextItem() == 4);
            Assert.IsTrue(list.GetNextItem() == 25);
        }

        [TestMethod]
        public void RemoveItemFailsWithMissingItem()
        {
            IList<int> list = new UnsortedList<int>(5);

            list.AddItem(16);
            list.AddItem(3);
            list.AddItem(11);
            list.AddItem(4);
            list.AddItem(25);

            Assert.ThrowsException<InvalidOperationException>(() => list.RemoveItem(32));
        }

        #endregion
    }
}
