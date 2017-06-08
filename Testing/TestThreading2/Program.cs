using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestThreading2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rep = 100000;
            int its = 100000;

            Measure("native create", rep, () =>
            {
                for (int i = 0; i < its; ++i)
                {
                    new Thread(() => createNative()).Start();
                }
            });

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            Measure("generic create", rep, () =>
            {
                for (int i = 0; i < its; ++i)
                {
                    new Thread(() => create<object>()).Start();
                }
            });

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            Type objType = typeof(object);
            Measure("reflect create", rep, () =>
            {
                for (int i = 0; i < its; ++i)
                {
                    new Thread(() => createReflect(objType)).Start();
                }
            });

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        private static object createReflect(Type t)
        {
            return Activator.CreateInstance(t);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private static T create<T>() where T : new()
        {
            return new T();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static object createNative()
        {
            return new object();
        }

        /// <summary>
        /// Measure the time it took to do shit
        /// </summary>
        /// <param name="what"></param>
        /// <param name="reps"></param>
        /// <param name="action"></param>
        private static void Measure(string what, int reps, Action action)
        {
            action(); //warm up

            double[] results = new double[reps];
            for (int i = 0; i < reps; ++i)
            {
                Stopwatch sw = Stopwatch.StartNew();
                action();
                results[i] = sw.Elapsed.Milliseconds;
            }
            Console.WriteLine("{0} - AVG = {1}, MIN = {2}, MAX = {3}",
                what, results.Average(), results.Min(), results.Max());
        }
    }
}
