using System;

namespace books
{
    class Book
    {
        public string Author{get; set;}
        public string Title{get; set;}
        public decimal Price{get; set;}

        public Book(string author,string title, decimal price)
        {
            Author = author;
            Price = price;
            Title = title;
        }
    }
}