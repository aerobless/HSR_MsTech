using System;
using System.ServiceModel;
using CounterServiceCommon;

namespace CounterService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class CounterService : ICounterService
    {

    }

}

