using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSRCounter
{
    public delegate void CounterEventHandler(Counter c, CounterEventArgs arg);
    public class Counter
    {
        //TODO: event type:
        private event EventHandler countValueChanged;
        private int count;
        public event CounterEventHandler CountValueChanged;
        private int p;

        public Counter()
        {
            count = 0;
        }
        public Counter(int val)
        {
            count = val;
        }

        public int Inc()
        {
            return ++Count;
        }
        public int Dec()
        {
            return --Count;
        }
        public void Reset()
        {
            Count = 0;
        }
        public void Reset(int val)
        {
            Count = val;
        }

        private void Notify(object sender, EventArgs e){
            if(CountValueChanged != null){
                CountValueChanged(this, null);
            }
        }

        public int Count
        {
            get{return count;}
            set { count = value;
                  Notify(this, null);
            }
        }
    }
}
