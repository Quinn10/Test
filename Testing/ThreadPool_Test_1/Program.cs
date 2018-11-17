using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPool_Test_1
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(ThreadProc);
            ThreadPool.QueueUserWorkItem(ThreadProc2);
            Console.WriteLine("Main thread does some work, then sleeps");
            Console.WriteLine("We are doing some overtime work");            
            Console.ReadLine();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="state"></param>
        private static void ThreadProc(Object state)
        {
            Console.WriteLine("Procedure 1 says : 'Hello from the thread pool'");
        }

        private static void ThreadProc2(Object state)
        {
            Console.WriteLine("Procedure 2 says : 'Hello from the thread pool'");
        }
    }
}
