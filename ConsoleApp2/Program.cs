using System;
using System.Collections.Generic;
using test;

namespace test
{

    public class Library
    {
        private Book[] books;
        private int count;

        public Library(int capacity)
        {
            books = new Book[capacity];
            count = 0;
        }

        public void AddBook(Book book)
        {
            if (count < books.Length)
            {
                books[count++] = book;
            }
            else
            {
                Book[] books2 = new Book[books.Length + 5];
                for (int i = 0; i < books.Length; i++)
                {
                    books2[i] = books[i];
                }
                books = books2;
            }
        }

        public void RemoveBook(Book book)
        {
            int index = Array.IndexOf(books, book);
            if (index != -1)
            {
                for (int i = index; i < count - 1; i++)
                {
                    books[i] = books[i + 1];
                }
                books[count - 1] = null;
                count--;
            }
        }

        public Book SearchByAuthor(string author)
        {
            Book result;
            foreach (var book in books)
            {
                if (book != null && book.Author == author)
                {
                    result = book;
                    return result;
                }
            }
            return null;
        }

        public Book SearchByYear(int year)
        {
            Book result;
            foreach (var book in books)
            {
                if (book != null && book.Year == year)
                {
                    result = book;
                    return result;
                }
            }
            return null;
        }

        public void SortBooksByTitle()
        {
            Array.Sort(books, 0, count, new TitleComparer());
        }

        public void SortBooksByAuthor()
        {
            Array.Sort(books, 0, count, new AuthorComparer());
        }

        public void SortBooksByYear()
        {
            Array.Sort(books, 0, count, new YearComparer());
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }
    }



    public class TitleComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return string.Compare(x.Title, y.Title);
        }
    }

    public class AuthorComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return string.Compare(x.Author, y.Author);
        }
    }

    public class YearComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Year.CompareTo(y.Year);
        }
    }

}

class Program
{
    static void Main()
    {
        Library library = new Library(0);
        Book book = new Book("e0e","fdwq",1222);
        library.AddBook(book);
        library.AddBook(book);
        library.AddBook(book);
        Console.ReadLine();
    }
}