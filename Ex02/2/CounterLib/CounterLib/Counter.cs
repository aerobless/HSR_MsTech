using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSRCounter
{
    public class Counter
    {
        private int count;
        Counter()
        {
            count = 0;
        }
        Counter(int val)
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
        public int Count
        {
            get{return count;}
            set{count=value;}
        }
    }
}
