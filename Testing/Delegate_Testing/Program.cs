using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Testing
{
    #region Crap
    public class Program
    {
        // delegates ???
        public delegate void SomeMethodPtr(string message);

        static void Main(string[] args)
        {
            // createthe handler
            var obj = new SomeMethodPtr(SomeMethod);
            // checked if handler is not null and then execute the method
            obj?.Invoke("Test");

            Console.ReadLine();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public static void SomeMethod(string message)
        {
            Console.WriteLine(message);
        }
    } 
    #endregion

    public class Program2
    {
        static void Main(string[] args)
        {
            var test = new MyClass();
            test.LongRunning(CallBack);
            Console.ReadLine();
        
        }

        private static void CallBack(int i)
        {
            Console.WriteLine(i);
        }
    }


    public class MyClass
    {                  
        public delegate void Callback(int i);

        public void LongRunning(Callback obj)
        {
            for (int i = 0; i < 1000; i++)
            {
                obj(i);
            }                             
        }
    }
}
