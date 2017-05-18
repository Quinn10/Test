using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genrics_Testing
{
    public class Utilities
    {
        private static object locker = new object();

        public T Max<T>(T a, T b) where T : IComparable
        {
            lock (locker)
            {
                var val = a.CompareTo(b) > 0 ? a : b;
                return val;
            }
        }
    }
}
