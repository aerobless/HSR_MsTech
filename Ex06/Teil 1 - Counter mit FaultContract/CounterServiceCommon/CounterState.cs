using System.Runtime.Serialization;

namespace CounterServiceCommon
{
    public class CounterState
    {
        int CountValue { get; set; }
        int MaxCountValue { get; set; }
        string CounterId { get; set; }
    }
}
