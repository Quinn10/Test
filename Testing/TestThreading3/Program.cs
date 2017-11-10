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
            InitTask.QueueAction(Test2);

            Console.ReadLine();
        }

        private static void Test2()
        {
            Console.WriteLine("THis is a second test");

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Console : " + i);
            }            
        }

        public static void Test()
        {

            Console.WriteLine("THis is a test");

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Console : " + i);
            }            
        }
    }
}
