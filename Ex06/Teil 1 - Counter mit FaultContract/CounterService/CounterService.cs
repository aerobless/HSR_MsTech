using System;
using System.ServiceModel;
using CounterServiceCommon;

namespace CounterService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class CounterService : ICounterService
    {
        public int CountValue { get; set; }
        public int MaxCountValue { get; set; }
        public int CounterState { get; set; }

        public int Increment() { ++CountValue; return CountValue; }
        public int Decrement() { --CountValue; return CountValue; }
    }
}