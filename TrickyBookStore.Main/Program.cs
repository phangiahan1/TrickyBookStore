using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrickyBookStore.Models;
using TrickyBookStore.Services;

namespace TrickyBookStore.Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServicesCollection services = new ServicesCollection();
            foreach (Book book in services.GetBooks(new long[] { 1, 2, 900 }))
            {
                Console.WriteLine(book.Price);
            }
        }
    }
}
