using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMasta.LearnWithCode.DataStructures.Stack;
using System;

namespace PMasta.LearnWithCode.Tests.Unit.DataStructures.Stack
{
    /// <summary>
    /// Tests related to the Stack data structure.
    /// </summary>
    [TestClass]
    public class StackFixture
    {
        #region Create Stack

        [TestMethod]
        public void ConstructSucceeds()
        {
            IStack<int> stack = new Stack<int>(3);

            Assert.IsNotNull(stack);
        }

        #endregion

        #region Empty

        [TestMethod]
        public void EmptySucceeds()
        {
            IStack<int> stack = new Stack<int>(3);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            stack.Empty();

            Assert.IsTrue(stack.IsEmpty());
        }

        #endregion

        #region IsEmpty

        [TestMethod]
        public void IsEmptySucceeds()
        {
            IStack<int> stack = new Stack<int>(3);

            Assert.IsNotNull(stack);
            Assert.IsTrue(stack.IsEmpty());
        }

        #endregion

        #region Push

        [TestMethod]
        public void PushSucceeds()
        {
            IStack<int> stack = new Stack<int>(3);

            stack.Push(3);

            Assert.IsFalse(stack.IsEmpty());
        }

        [TestMethod]
        public void PushFailsWithFullStack()
        {
            IStack<int> stack = new Stack<int>(3);

            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Assert.ThrowsException<InvalidOperationException>(() => stack.Push(6));
        }

        #endregion

        #region Pop

        [TestMethod]
        public void PopSucceeds()
        {
            IStack<int> stack = new Stack<int>(3);
            stack.Push(3);

            Assert.IsTrue(stack.Pop() == 3);
            Assert.IsTrue(stack.IsEmpty());
        }

        [TestMethod]
        public void PopFailsWithEmptyStack()
        {
            IStack<int> stack = new Stack<int>(3);

            Assert.ThrowsException<InvalidOperationException>(() => stack.Pop());
        }

        [TestMethod]
        public void PopSucceedsConsecutively()
        {
            IStack<int> stack = new Stack<int>(3);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Assert.IsTrue(stack.Pop() == 5);
            Assert.IsTrue(stack.Pop() == 4);
            Assert.IsTrue(stack.Pop() == 3);
            Assert.IsTrue(stack.IsEmpty());
        }

        #endregion

        #region Top

        [TestMethod]
        public void TopSucceeds()
        {
            IStack<int> stack = new Stack<int>(3);
            stack.Push(3);

            Assert.IsTrue(stack.Top() == 3);
            Assert.IsTrue(stack.Pop() == 3);
        }

        [TestMethod]
        public void TopFailsWithEmptyStack()
        {
            IStack<int> stack = new Stack<int>(3);

            Assert.ThrowsException<InvalidOperationException>(() => stack.Top());
        }

        #endregion
    }
}
