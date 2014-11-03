using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public class CounterImpl : ICounter
    {
        public event CountChangedEventHandler CountChanged;

        public int Count {
            get { return Count; }
            set { Count = value; OnCounterChanged(new CountChangedEventArgs(value, Count)); }
        }

        public void Increment()
        {
            ++Count;
        }
        public void Decrement()
        {
            --Count;
        }
        public void Reset()
        {
            Count = 0;
        }

        protected void OnCounterChanged(CountChangedEventArgs eventArgs)
        {
            if (CountChanged != null)
            {
                CountChanged(this, eventArgs);
            }
        }
    }
}
