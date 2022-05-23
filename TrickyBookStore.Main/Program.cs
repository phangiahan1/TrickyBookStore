﻿using System;
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

            Console.WriteLine("Enter customerId:");
            int customerId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month:");
            int month = Convert.ToInt32(Console.ReadLine());

            DateTimeOffset startDate = services.getStartDate(year, month);
            DateTimeOffset endDate = services.getEndDate(year, month);

            double total = services.getPayment(customerId, startDate, endDate);
            Console.WriteLine("=> Total: " + total);
        }
    }
}
