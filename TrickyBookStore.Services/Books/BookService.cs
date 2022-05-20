using System;
using System.Collections.Generic;
using System.Linq;
using TrickyBookStore.Models;

namespace TrickyBookStore.Services.Books
{
    internal class BookService : IBookService
    {
        IList<Book> allBooks = (IList<Book>)Store.Books.Data;
        public Book GetBook(long id)
        {
            Book book = new Book(); 
            try
            {
                book = allBooks.FirstOrDefault(bookItem => bookItem.Id == id);
                return book;
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message); 
            }
            return null;
        }

        public IList<Book> GetBooks(params long[] ids)
        {
            IList<Book> targetBooks = new List<Book>();
            Book book = new Book();
            foreach (long id in ids)
            {
                book=GetBook(id);
                if (book != null)
                {
                    targetBooks.Add(book);
                }
            }
            return targetBooks;
        }

        public IList<Book> GetNewBooks(IList<Book> books)
        {
            IList < Book > newBooks = new List<Book>();
            foreach (Book book in books)
            {
                if (!book.IsOld)
                {
                    newBooks.Add(book);
                }
            }
            return newBooks;
        }

        public IList<Book> GetOldBooks(IList<Book> books)
        {
            IList<Book> oldBooks = new List<Book>();
            foreach (Book book in books)
            {
                if (book.IsOld)
                {
                    oldBooks.Add(book);
                }
            }
            return oldBooks;
        }
    }
}
