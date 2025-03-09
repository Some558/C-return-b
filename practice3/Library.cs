using System;
using System.Linq;

namespace books
{
    class Library
    {
        List<string> Book;

        public string AddBook(Book book)
        {
            Book.Add(book);
        }

        public void GetExpensiveBooks(int price)    
        {
            var filteredBooks = Book.Where(n => n >= 1000);
            foreach(var num in filteredBooks)
            {
                Console.WriteLine(num);
            }
        }
    }
}