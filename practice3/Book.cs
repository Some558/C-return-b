using System;

namespace books
{
    class Book
    {
        private string Author;
        private string Title;
        private decimal Price;

        public string Author{get; set;}
        public string Title{get; set;}
        public decimal Price{get; set;}

        public Book(string author,string titel, decimal price)
        {
            Author = author;
            Price = price;
            Title = title;
        }
    }
}