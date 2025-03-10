using System;

namespace books
 {
    class Program
    {
        static void Main()
        {
            List<Book> Books = new List<Book>
            {
            new Book("tom", "home", 1456.2m),
            new Book("ken", "mountain", 659.2m),
            new Book("jin", "sea", 1320.2m)
            };

        Library library = new Library();
        foreach(var book in library.GetExpensiveBooks(Books))
            {
                Console.WriteLine($"{book.Title} - {book.Author} - {book.Price}円");
            }
        }
        
    }
 }