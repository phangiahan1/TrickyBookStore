using System;
using System.Collections.Generic;
using TrickyBookStore.Models;
using TrickyBookStore.Services.Books;
using TrickyBookStore.Services.Customers;

namespace TrickyBookStore.Services.PurchaseTransactions
{
    internal class PurchaseTransactionService : IPurchaseTransactionService
    {
        IBookService BookService { get; }
        IList<PurchaseTransaction> allPurchaseTransactions = (IList<PurchaseTransaction>)Store.PurchaseTransactions.Data;

        public PurchaseTransactionService(IBookService bookService)
        {
            BookService = bookService;
        }

        public IList<PurchaseTransaction> GetPurchaseTransactions(long customerId, DateTimeOffset fromDate, DateTimeOffset toDate)
        {
            IList<PurchaseTransaction> purchaseTransactions = new List<PurchaseTransaction>();
            foreach (var transaction in allPurchaseTransactions)
            {
                if(transaction.CustomerId == customerId && transaction.CreatedDate>=fromDate && transaction.CreatedDate <= toDate)
                {
                    purchaseTransactions.Add(transaction);
                    
                }
            }
            return purchaseTransactions;
        }

        public IList<Book> GetCustomerBooks(long customerId, DateTimeOffset fromDate, DateTimeOffset toDate)
        {
            IList<Book> books = new List<Book>();
            IList<PurchaseTransaction> purchaseTransactions = GetPurchaseTransactions(customerId, fromDate, toDate);    
            foreach (var transaction in purchaseTransactions)
            {
                books.Add(BookService.GetBook(transaction.BookId));
            }
            return books;
        }

        public IList<Book> GetCustomerOldBooks(long customerId, DateTimeOffset fromDate, DateTimeOffset toDate)
        {
            return BookService.GetOldBooks(GetCustomerBooks(customerId, fromDate, toDate));
        }

        public IList<Book> GetCustomerNewBooks(long customerId, DateTimeOffset fromDate, DateTimeOffset toDate)
        {
            return BookService.GetOldBooks(GetCustomerBooks(customerId, fromDate, toDate));
        }
    }
}
