using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Genrics_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            //var book = new Book() { Isbn = "11111", Title = "C# Advance" };

            ////var numbers = new List<int>();
            ////numbers.Add(10);


            ////var books = new BookList();
            ////books.Add(book);

            //var numebers = new GenericList<int>();
            //numebers.Add(10);

            //var books = new GenericList<Book>();
            //books.Add(book);


            //var dictionary = new GenricDictionary<string, Book>();
            //dictionary.Add("Test", book);

            int test = 0;
            double decimalTest = 0;

            while (test == 0 && decimalTest == 0)
            {
                Thread thread = new Thread(() =>{
                    test = new Utilities().Max<int>(10, 1);
                });thread.Start();

                Thread thread2 = new Thread(() =>
                {
                    decimalTest = new Utilities().Max<double>(100.00, 226541.50);
                }); thread2.Start();
            }
            Console.WriteLine(test);
            Console.WriteLine(decimalTest);

            Console.ReadLine();

        }
    }
}
