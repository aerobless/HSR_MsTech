using System.ServiceModel;

namespace CounterServiceCommon
{
    public interface ICounterService
    {
        int CountValue { get; set; }
        int MaxCountValue { get; set; }
        int CounterState { get; set; }

        void Increment();
        void Decrement();
    }
}
