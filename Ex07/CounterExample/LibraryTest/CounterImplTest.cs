using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryTest
{
    [TestClass]
    public class CounterImplTest
    {
        private ICounter mCounter;

        [TestInitialize]
        public void Initialize()
        {
            mCounter = new CounterImpl();
        }

        [TestMethod]
        public void Precondition()
        {
            Assert.AreEqual(0, mCounter.Count);
        }

        [TestMethod]
        public void Increment()
        {
            Precondition();

            mCounter.Increment();

            Assert.AreEqual(1, mCounter.Count);
        }

        [TestMethod]
        public void Decrement()
        {
            Precondition();

            mCounter.Decrement();

            Assert.AreEqual(-1, mCounter.Count);
        }

        [TestMethod]
        public void Set()
        {
            Precondition();

            mCounter.Count = 5;

            Assert.AreEqual(5, mCounter.Count);
        }

        [TestMethod]
        public void Reset()
        {
            Precondition();

            Increment();
            mCounter.Reset();

            Precondition();
        }
    }
}