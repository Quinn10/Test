using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestThreading3
{
    class Program
    {
        static void Main(string[] args)
        {
            InitTask.QueueAction(Test);
        }

        public static void Test()
        {
            Console.WriteLine("THis is a test");
        }

    }
}
