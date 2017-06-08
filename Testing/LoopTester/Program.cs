using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LoopTester
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; ++i)
            {
                Console.WriteLine(JJsMethod(i));
            }
            Console.ReadLine();
        }

        private static string JJsMethod(int number)
        {     
            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine("I am running in here");
            }        
            return string.Format("JJ says that the number is : {0} :  plus your reference : {1}", number, Guid.NewGuid());
        }
    }
}
