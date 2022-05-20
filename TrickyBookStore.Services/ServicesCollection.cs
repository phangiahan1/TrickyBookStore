using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrickyBookStore.Models;
using TrickyBookStore.Services.Books;
using TrickyBookStore.Services.Customers;
using TrickyBookStore.Services.Payment;
using TrickyBookStore.Services.PurchaseTransactions;
using TrickyBookStore.Services.Store;
using TrickyBookStore.Services.Subscriptions;

namespace TrickyBookStore.Services
{
    public class ServicesCollection
    {
        IBookService bookService = new BookService();
        ISubscriptionService subscriptionService = new SubscriptionService();
        ICustomerService customerService = new CustomerService(new SubscriptionService());
        IPurchaseTransactionService purchaseTransactionService = new PurchaseTransactionService(new BookService());
        IPaymentService paymentService = new PaymentService(new CustomerService(new SubscriptionService()), new PurchaseTransactionService(new BookService()));

        public Customer GetCustomerById(long id)
        {
            return customerService.GetCustomerById(id); 
        }
        public IList<Book> GetBooks(params long[] ids)
        {
            return bookService.GetBooks(ids);
        }

        public IList<PurchaseTransaction> getPurchaseTransactions(long customerId, DateTimeOffset fromDate, DateTimeOffset toDate)
        {
            return purchaseTransactionService.GetPurchaseTransactions(customerId, fromDate, toDate);
        }
        public double getPayment(long customerId, DateTimeOffset fromDate, DateTimeOffset toDate)
        {
            return paymentService.GetPaymentAmount(customerId, fromDate, toDate);
        }
        public IList<Subscription> GetSubscriptions(params int[] ids)
        {
            return subscriptionService.GetSubscriptions(ids);
        }
    }
}
