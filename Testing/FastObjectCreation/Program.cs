using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastObjectCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<INamable> testList = new List<INamable>();
                testList.Add(createNative<Person>("Quinten"));
                testList.Add(createNative<Car>("Nissan"));
                testList.ForEach(item => { Console.WriteLine(item.Name); });
            }
            catch (Exception ex)
            {

                throw ex;
            }
            Console.ReadLine();
        }

        static T createNative<T>(string name) where T : INamable, new()
        {
            return new T() { Name = name };
        }
    }
}
