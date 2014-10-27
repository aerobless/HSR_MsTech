using System.ServiceModel;

namespace CounterServiceHost
{
    internal class CounterServiceHost
    {
        private static ServiceHost myServiceHost;

        internal static void StartService()
        {
            //Instantiate new ServiceHost 
            myServiceHost = new ServiceHost(typeof(CounterService.CounterService));

            //Open myServiceHost
            myServiceHost.Open();
        }

        internal static void StopService()
        {
            //Call StopService from your shutdown logic (i.e. dispose method)
            if (myServiceHost.State != CommunicationState.Closed)
            {
                myServiceHost.Close();
            }
        }
    }
}
