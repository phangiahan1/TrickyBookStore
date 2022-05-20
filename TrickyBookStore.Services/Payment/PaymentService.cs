using System;
using System.Collections.Generic;
using System.Linq;
using TrickyBookStore.Models;
using TrickyBookStore.Services.Books;
using TrickyBookStore.Services.Customers;
using TrickyBookStore.Services.PurchaseTransactions;
using TrickyBookStore.Services.Subscriptions;

namespace TrickyBookStore.Services.Payment
{
    public class PaymentService : IPaymentService
    {
        ICustomerService CustomerService { get; }
        IPurchaseTransactionService PurchaseTransactionService { get; }

        public PaymentService(ICustomerService customerService, 
            IPurchaseTransactionService purchaseTransactionService)
        {
            CustomerService = customerService;
            PurchaseTransactionService = purchaseTransactionService;
        }

        public double GetPaymentAmount(long customerId, DateTimeOffset fromDate, DateTimeOffset toDate)
        {
            Customer customer =  CustomerService.GetCustomerById(customerId);
            IList<Book> customerBooks = PurchaseTransactionService.GetCustomerBooks(customerId, fromDate, toDate);
            IList<Subscription> customerSubscriptions = CustomerService.GetSubscriptions(customer);

            double TotalBeforeDiscount = GetTotalBeforeDiscount(customerBooks);
            double TotalDiscount = GetTotalDiscount(customerSubscriptions, customerBooks);
            double Total = TotalBeforeDiscount - TotalDiscount;

            Console.WriteLine("Price before discount: " + TotalBeforeDiscount);
            Console.WriteLine("Price discount: " + TotalDiscount);
            Console.WriteLine("Final price: " + Total);

            return Total;
        }

        public double GetTotalDiscount(IList<Subscription> customerSubscriptions, IList<Book> customerBooks)
        {
            return 0;
        }

        public double GetTotalBeforeDiscount(IList<Book> customerBooks)
        {
            double totalBeforeDiscount = 0;
            foreach (Book customerBook in customerBooks)
            {
                totalBeforeDiscount += customerBook.Price;
            }
            return totalBeforeDiscount;
        }
    }
}
