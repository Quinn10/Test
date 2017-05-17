using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            var test = new Utilities().Max<int>(10, 1);
            Console.WriteLine(test);
            Console.ReadLine();

        }
    }
}
                                                                                