using System;             
using System.Threading;

namespace TestThreading3
{
                
    /// <summary>
    /// Executes asynchronous tasks outside of the main applicaiton domain
    /// </summary>
    /// <remarks> </remarks>
    internal class InitTask
    {
        /// <summary>
        /// Keeps a lock on the executing thread count call
        /// </summary>
        static object EXEC_THREAD_COUNT_LOCK = new object();


        /// <summary>
        /// Queues a task for execution
        /// </summary>
        /// <param name="task"></param>
        static internal void QueueAction(Action task)
        {
            if (task == null) return;

            ///create a call 
            WaitCallback callback = new WaitCallback(ExecuteAction);
            QueueCallBack(callback, task);

        }


        /// <summary>
        /// Queues the WaitCallBack delegate on the ThreadPool thread
        /// </summary>
        /// <param name="callback"></param>
        static internal void QueueCallBack(WaitCallback callback)
        {
            if (callback == null) return;
            ThreadPool.QueueUserWorkItem(callback);
        }

        /// <summary>
        /// Queues the WaitCallBack delegate 
        /// </summary>
        /// <param name="callback"></param>
        /// <param name="stateInfo"></param>
        static internal void QueueCallBack(WaitCallback callback, object stateInfo)
        {
            ThreadPool.QueueUserWorkItem(callback, stateInfo);
        }


        /// <summary>
        /// Returns the number of executing tasks on the current threadpool thread
        /// </summary>
        static int GetExecutingThreadCount()
        {
            int workerThreads = 0;
            int completionThreads = 0;

            int maxThreads = 0;
            int maxCompletionThreads = 0;

            lock (EXEC_THREAD_COUNT_LOCK)
            {
                ThreadPool.GetMaxThreads(out maxThreads, out maxCompletionThreads);
                ThreadPool.GetAvailableThreads(out workerThreads, out completionThreads);
            }

            return maxThreads - workerThreads;
        }


        /// <summary>
        /// Executes an Action in the current ThreadPool thread
        /// </summary>
        /// <param name="act"></param>
        static internal void ExecuteAction(object act)
        {
            if (act == null) return;
            if (!(act is Action)) return;

            try
            {
                ((Action)act).Invoke();
            }
            catch (Exception ex)
            {
                LogException(typeof(InitTask), ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ex"></param>
        private static void LogException(Type type, Exception ex)
        {
            throw ex;
        }
    }      
}
