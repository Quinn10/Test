using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSIL
{
    class Program
    {
        static void Main(string[] args)
        {
            var o = createNative();
            o = create<Object>();

            Console.ReadLine();
        }

        static object createNative()
        {
            return new object();
        }

        static T create<T>() where T : new()
        {
            return new T();
        }
    }
}
