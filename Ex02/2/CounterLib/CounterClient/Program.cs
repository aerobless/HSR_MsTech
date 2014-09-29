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
            myCounter.CountValueChanged += ValueChanged;

            myCounter.Inc();

            Console.Out.WriteLine("End");
            Console.ReadLine();
        }

        static void ValueChanged(Counter c, CounterEventArgs arg){
            Console.Out.WriteLine(c.Count);
        }
    }
}
