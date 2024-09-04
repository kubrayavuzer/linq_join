using linq_join;
using System;
using System.Collections.Generic;
using System.Linq;

class Program

{
    static void Main(string[] args)
    {
        //yazar tablosu oluştur
        List<Author> authors = new List<Author>
        {

            new Author { AuthorId = 1, Name = "Orhan Pamuk" },
            new Author { AuthorId = 2, Name = "Elif Şafak" },
            new Author { AuthorId = 3, Name = "Ahmet Ümit" },

        };

        List<book> books = new List<book>
        {
            new book { bookId = 1, title = "Kar", authorId = 1 },
            new book { bookId = 2, title = "İstanbul", authorId = 1 },
            new book { bookId = 3, title = "10 Minutes 38 Seconds in This Strange World", authorId = 2 },
            new book { bookId = 4, title = "Beyoğlu Rapsodisi", authorId = 3 },
        };

        var query = from book in books
                    join author in authors on book.authorId equals author.AuthorId
                    select new { BookTitle = book.title, AuthorName = author.Name };

        //yazdırma ekranı

        foreach (var item in query)
        {
            Console.WriteLine($"Book: {item.BookTitle}, Auhor: {item.AuthorName}");
        }
    }
}