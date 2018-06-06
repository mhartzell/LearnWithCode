using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMasta.LearnWithCode.DataStructures.Queue;
using System;

namespace PMasta.LearnWithCode.Tests.Unit.DataStructures.Queue
{
    /// <summary>
    /// Tests related to the Queue data structure.
    /// </summary>
    [TestClass]
    public class QueueFixture
    {
        #region Construct

        [TestMethod]
        public void ConstructSucceeds()
        {
            IQueue<int> queue = new Queue<int>(3);

            Assert.IsNotNull(queue);
        }

        [TestMethod]
        public void ConstructFailsWithZeroSize()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Queue<int>(0));
        }

        #endregion

        #region Dequeue

        [TestMethod]
        public void DequeueSucceeds()
        {
            IQueue<int> queue = new Queue<int>(3);
            queue.Enqueue(3);

            Assert.IsTrue(queue.Dequeue() == 3);
        }

        [TestMethod]
        public void DequeueSucceedsInOrder()
        {
            IQueue<int> queue = new Queue<int>(3);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Assert.IsTrue(queue.Dequeue() == 3);
            Assert.IsTrue(queue.Dequeue() == 4);

            queue.Enqueue(1);
            queue.Enqueue(3);

            Assert.IsTrue(queue.Dequeue() == 5);
            Assert.IsTrue(queue.Dequeue() == 1);
            Assert.IsTrue(queue.Dequeue() == 3);

            Assert.IsTrue(queue.IsEmpty());
        }

        [TestMethod]
        public void DequeueFailsWithEmptyQueue()
        {
            IQueue<int> queue = new Queue<int>(3);

            Assert.ThrowsException<InvalidOperationException>(() => queue.Dequeue());
        }

        #endregion

        #region Empty

        [TestMethod]
        public void EmptySucceeds()
        {
            IQueue<int> queue = new Queue<int>(3);
            queue.Enqueue(3);

            queue.Empty();

            Assert.IsTrue(queue.IsEmpty());
        }

        #endregion

        #region Enqueue

        [TestMethod]
        public void EnqueueSucceeds()
        {
            IQueue<int> queue = new Queue<int>(3);
            queue.Enqueue(3);

            Assert.IsFalse(queue.IsFull());
        }

        [TestMethod]
        public void EnqueueFailsWithFullQueue()
        {
            IQueue<int> queue = new Queue<int>(3);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Assert.ThrowsException<InvalidOperationException>(() => queue.Enqueue(6));
        }

        #endregion

        #region IsEmpty

        [TestMethod]
        public void IsEmptySucceeds()
        {
            IQueue<int> queue = new Queue<int>(3);

            Assert.IsTrue(queue.IsEmpty());
        }

        #endregion

        #region IsFull

        [TestMethod]
        public void IsFullSucceeds()
        {
            IQueue<int> queue = new Queue<int>(1);
            queue.Enqueue(3);

            Assert.IsTrue(queue.IsFull());
        }

        #endregion
    }
}
