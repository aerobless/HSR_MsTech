using System.ServiceModel;

namespace CounterServiceCommon
{
    public interface ICounterService
    {
        int Increment();
        int Decrement();
    }
}
