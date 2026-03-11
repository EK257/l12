using System;
using System.Collections.Generic;
using System.Text;

namespace l12
{
    internal class Book
    {
        public String title = "Неизвестно";
        public String author = "Неизвестно";
        public int year;

        public Book(String title, String author, int year)
        {
            this.title = title;
            this.author = author;
            this.year = year;
        }
        public Book()
        {}

        public String getInfo() 
        {
            return $"'{title}', {author} ({year})";
        }
    }
}
