using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSRCounter

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Start:");
            Counter myCounter = new Counter(10);

            CounterObeserver myObserver1 = new CounterObeserver("obs1");
            CounterObeserver myObserver2 = new CounterObeserver("obs2");

            myCounter.CountValueChanged += myObserver1.OnCountValueChanged;
            myCounter.CountValueChanged += myObserver2.OnCountValueChanged;
            myCounter.Inc();

            myCounter.CountValueChanged -= myObserver1.OnCountValueChanged;
            myCounter.Reset(100);

            Console.Out.WriteLine("End");
            Console.ReadLine();
        }

        static void ValueChanged(Counter c, CounterEventArgs arg){
            Console.Out.WriteLine(c.Count);
        }
    }

    class CounterObeserver
    {
        private string name;
        public CounterObeserver(string name) { this.name = name; }
        public void OnCountValueChanged(Counter c, CounterEventArgs arg)
        {
            Console.Out.WriteLine("CounterObserver "+name+": Counter changed: Value = "+c.Count);
        }
    }
}
