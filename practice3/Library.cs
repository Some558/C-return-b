using System;
using System.Linq;

namespace books
{
    class Library
    {
        List<Book> Books;

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public List<Book> GetExpensiveBooks(List<Books> books)    
        {
            return books.Where(book => book.Price >= 1000).ToList();
        }
    }
}