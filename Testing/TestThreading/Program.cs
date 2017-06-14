using System;
using System.Threading;
using System.Threading.Tasks;

namespace TestThreading
{
    class Program
    {
        private static object locker = new object();
        static void Main(string[] args)
        {
            Action<string> writeOutput = (message) => 
            {
                lock (locker)
                {
                    Console.WriteLine(message); 
                }
            };

            Thread t = new Thread(() =>
            {
                writeOutput("Hello I am a thread");
            });                                    
            t.Start();

            Task task = Task.Factory.StartNew(() =>
            {
                writeOutput("Hello I am a task");
            });

            Task secondTask = Task.Factory.StartNew<bool>(Hacker);

            secondTask.Wait();

            var value = secondTask;

            writeOutput("Hi I am the main thread");

            Console.ReadLine();
        }

        public static bool Hacker()
        {
            Console.WriteLine("I am the last task to fire");
            return true;
        }
    }
}
