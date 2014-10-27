using System;
using System.ServiceModel;
using CounterServiceCommon;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CounterService.UnitTest
{
    [TestClass]
    public class CounterServiceTest
    {
        private readonly ICounterService target = new CounterService();

        [TestInitialize]
        public void InitializeTestData()
        {
            target.CounterId = "MyTestCounter";
            target.CountValue = 0;
            target.MaxCountValue = 10;
        }

        [TestMethod]
        public void TestCountValue()
        {
            Assert.AreEqual(0, target.CountValue);

            target.CountValue = 5;

            Assert.AreEqual(5, target.CountValue);
        }

        [TestMethod]
        public void TestMaxCountValue()
        {
            Assert.AreEqual(10, target.MaxCountValue);

            target.MaxCountValue = 5;

            Assert.AreEqual(5, target.MaxCountValue);
        }

        [TestMethod]
        public void TestCounterId()
        {
            Assert.AreEqual("MyTestCounter", target.CounterId);

            target.CounterId = "MyTestCounterNew";

            Assert.AreEqual("MyTestCounterNew", target.CounterId);
        }

        [TestMethod]
        public void TestCounterState()
        {
            CounterState state = target.CounterState;

            Assert.AreEqual(0, state.CountValue);
            Assert.AreEqual(10, state.MaxCountValue);
            Assert.AreEqual("MyTestCounter", state.CounterId);

            state.CountValue = 5;
            state.MaxCountValue = 5;
            state.CounterId = "MyTestCounterNew";

            target.CounterState = state;

            Assert.AreEqual(5, state.CountValue);
            Assert.AreEqual(5, state.MaxCountValue);
            Assert.AreEqual("MyTestCounterNew", state.CounterId);
        }

        [TestMethod]
        public void TestIncrement()
        {
            Assert.AreEqual(0, target.CountValue);

            target.Increment();

            Assert.AreEqual(1, target.CountValue);
        }

        [TestMethod]
        public void TestDecrement()
        {
            Assert.AreEqual(0, target.CountValue);

            target.Decrement();

            Assert.AreEqual(-1, target.CountValue);
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException<CounterFaultContract>))]
        public void TestCountValueGreaterThanMaxCountValue()
        {
            try
            {
                target.CountValue = 999;
                Assert.Fail();
            }
            catch (FaultException<CounterFaultContract>)
            {
                Assert.AreEqual(0, target.CountValue);
                throw;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException<CounterFaultContract>))]
        public void TestMaxCountValueLowerThanCountValue()
        {
            try
            {
                target.MaxCountValue = -999;
                Assert.Fail();
            }
            catch (FaultException<CounterFaultContract>)
            {
                Assert.AreEqual(10, target.MaxCountValue);
                throw;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException<CounterFaultContract>))]
        public void TestCounterStateWithCountValueGreaterThanMaxCountValue()
        {
            try
            {
                target.CounterState = new CounterState(999, 10, "MyTestCounterNew");
                Assert.Fail();
            }
            catch (FaultException<CounterFaultContract>)
            {
                CounterState state = target.CounterState;

                Assert.AreEqual(0, state.CountValue);
                Assert.AreEqual(10, state.MaxCountValue);
                Assert.AreEqual("MyTestCounter", state.CounterId);

                throw;
            }
        }


    }
}
