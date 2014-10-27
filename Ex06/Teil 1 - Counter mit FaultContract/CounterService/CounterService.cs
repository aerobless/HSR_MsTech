using System;
using System.ServiceModel;
using CounterServiceCommon;

namespace CounterService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class CounterService : ICounterService
    {
        int CountValue { get; set; }
        int MaxCountValue { get; set; }
        int CounterState { get; set; }

        public void Increment() { ++CountValue; }
        public void Decrement() { --CountValue; }
    }
}