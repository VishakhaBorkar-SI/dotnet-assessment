using System;
using System.Collections.Generic;
namespace LibraryMngSystem
{
    

    class Book
    {
        public string Title { get; }
        public string Author { get; }
        public string Genre { get; }
        public int QuantityAvailable { get; }

        public Book(string title, string author, string genre, int quantityAvailable)
        {
            Title = title;
            Author = author;
            Genre = genre;
            QuantityAvailable = quantityAvailable;
        }
    }

    class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void DisplayBookList()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("The library is empty. No books available.");
            }
            else
            {
                Console.WriteLine("Book List:");
                foreach (var book in books)
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Quantity Available: {book.QuantityAvailable}");
                }
            }
        }

        public void SearchByTitle(string title)
        {
            List<Book> foundBooks = books.FindAll(book => book.Title.ToLower().Contains(title.ToLower()));
            if (foundBooks.Count == 0)
            {
                Console.WriteLine("No books found with the given title.");
            }
            else
            {
                Console.WriteLine("Books Found:");
                foreach (var book in foundBooks)
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Quantity Available: {book.QuantityAvailable}");
                }
            }
        }

        public void SearchByAuthor(string author)
        {
            List<Book> foundBooks = books.FindAll(book => book.Author.ToLower().Contains(author.ToLower()));
            if (foundBooks.Count == 0)
            {
                Console.WriteLine("No books found by the given author.");
            }
            else
            {
                Console.WriteLine("Books Found:");
                foreach (var book in foundBooks)
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Quantity Available: {book.QuantityAvailable}");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine("1. Add Book to Library");
                Console.WriteLine("2. Display Book List");
                Console.WriteLine("3. Search Books by Title");
                Console.WriteLine("4. Search Books by Author");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Book Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter Book Author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter Book Genre: ");
                        string genre = Console.ReadLine();
                        Console.Write("Enter Quantity Available: ");
                        int quantityAvailable = Convert.ToInt32(Console.ReadLine());

                        Book book = new Book(title, author, genre, quantityAvailable);
                        library.AddBook(book);
                        Console.WriteLine("Book added to the library.");
                        break;
                    case 2:
                        library.DisplayBookList();
                        break;
                    case 3:
                        Console.Write("Enter Title to search: ");
                        string searchTitle = Console.ReadLine();
                        library.SearchByTitle(searchTitle);
                        break;
                    case 4:
                        Console.Write("Enter Author to search: ");
                        string searchAuthor = Console.ReadLine();
                        library.SearchByAuthor(searchAuthor);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }
    }

}