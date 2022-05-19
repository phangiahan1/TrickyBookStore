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
        
        public IList<Book> GetBooks(params long[] ids)
        {
            return bookService.GetBooks(ids);
        }

        public Book GetBook(long id)
        {
           return bookService.GetBook(id);
        }
    }
}
