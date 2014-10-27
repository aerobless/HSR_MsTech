using System;

namespace CounterServiceHost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Service wird gestartet...");
            CounterServiceHost.StartService();
            Console.WriteLine("Service ready. Press Enter to quit.");
            Console.ReadLine();
            CounterServiceHost.StopService();
        }
    }
}
