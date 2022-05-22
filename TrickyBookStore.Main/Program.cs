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
            double b0 = services.getPayment(1, new DateTimeOffset(new DateTime(2017, 1, 2)), new DateTimeOffset(new DateTime(2019, 1, 21)));
            Console.WriteLine("============");
            double b1 = services.getPayment(2, new DateTimeOffset(new DateTime(2017, 1, 2)), new DateTimeOffset(new DateTime(2019, 1, 21)));
            Console.WriteLine("============");
            double b2 = services.getPayment(3, new DateTimeOffset(new DateTime(2017, 1, 2)), new DateTimeOffset(new DateTime(2019, 1, 21)));
            Console.WriteLine("============");
            double b3 = services.getPayment(4, new DateTimeOffset(new DateTime(2017, 1, 2)), new DateTimeOffset(new DateTime(2019, 1, 21)));
            Console.WriteLine("============");
            double b4 = services.getPayment(5, new DateTimeOffset(new DateTime(2017, 1, 2)), new DateTimeOffset(new DateTime(2019, 1, 21)));
            Console.WriteLine("============");
            double b5 = services.getPayment(6, new DateTimeOffset(new DateTime(2017, 1, 2)), new DateTimeOffset(new DateTime(2019, 1, 21)));
            Console.WriteLine("============");
            double b6 = services.getPayment(7, new DateTimeOffset(new DateTime(2017, 1, 2)), new DateTimeOffset(new DateTime(2019, 1, 21)));
        }
    }
}
