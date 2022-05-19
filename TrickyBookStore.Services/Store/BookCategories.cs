using System.Collections.Generic;
using TrickyBookStore.Models;

namespace TrickyBookStore.Services.Store
{
    public static class BookCategories
    {
        public static readonly IEnumerable<BookCategory> Data = new List<BookCategory>
        {
            new BookCategory { Title = "Travel", Id = 1 },
            new BookCategory { Title = "History", Id = 2 },
            new BookCategory { Title = "Novels", Id = 3 },
            new BookCategory { Title = "Health", Id = 4 }
        };
    }
}
