using System;
using System.Collections.Generic;
using System.Linq;
using TrickyBookStore.Models;

namespace TrickyBookStore.Services.Books
{
    internal class BookService : IBookService
    {
        public Book GetBook(long id)
        {
            IList<Book> allBooks = (IList<Book>)Store.Books.Data;
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
            IList<Book> allBooks = (IList<Book>)Store.Books.Data;
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
    }
}
