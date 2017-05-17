using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genrics_Testing
{
    public class GenericList<T>
    {
        public void Add(T value)
        {

        }


        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }

    }

    public class GenricDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {
        
        }
    }
}
