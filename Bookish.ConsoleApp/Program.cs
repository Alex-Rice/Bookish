using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookish.DataAccess;

namespace Bookish.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var book in HelperMethods.GetBookList())
            {
                Console.WriteLine(book);
            }
        }
    }
}
