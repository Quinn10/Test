using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            var o = createNative();
            o = create<Object>();
        }

        static T create<T>() where T: new()
        {
            return new T();                  
        }

        static object createNative()
        {
            return new object();
        }        
    }
}
