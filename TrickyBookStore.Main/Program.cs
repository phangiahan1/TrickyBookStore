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

            //foreach (Subscription book in services.GetSubscriptions(new int[2] {1, 2}))
            //{
            //    Console.WriteLine(book.Id);
            //}
            double b = services.getPayment(6, new DateTimeOffset(new DateTime(2017, 1, 2)), new DateTimeOffset(new DateTime(2019, 1, 21)));
        }
    }
}
