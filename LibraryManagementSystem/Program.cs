using System;
using System.Linq;
using LibraryManagementSystem;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        #region Modellenmiş ilişkili Author- Book örnek listesi

        List<Author> authorsList = new List<Author>
        {
            new Author
            {
                AuthorId = 1,
                FirstName = "Reşat Nuri",
                LastName = "Güntekin",
                Books = new List<Book>
                {
                    new Book { BookId = 1, ISBN = "8635A879", Title = "Çalıkuşu", PublicationYear = new DateTime(2019, 3, 15), Type = "Roman", PageCount = 350, CopyCount=50 }
                }
            },
            #endregion

        #region İkinci Modellenmiş ilişkili Author- Book örnek listesi
            new Author
            {
                AuthorId = 2,
                FirstName = "Ömer",
                LastName = "Seyfettin",
                Books = new List<Book>
                {
                    new Book { BookId = 2, ISBN = "1234B567", Title = "Efruz Bey", PublicationYear = new DateTime(2020, 4, 20), Type = "Hikaye", PageCount = 200, CopyCount=30 }
                }
            },
        };
        #endregion

        #region YAZAR, KİTAP BAŞ HARFLERİNE GÖRE ÖRNEK BEST PRACTICE


        Console.WriteLine("Select the type you want to filter:");
        Console.WriteLine("1. Author");
        Console.WriteLine("2. Book");
        string secim = Console.ReadLine();

        if (secim == "1")
        {
            Console.WriteLine("Please enter the letter for your author selection:");
            string authorsKey = Console.ReadLine()?.Trim().ToLower();

            if (!string.IsNullOrEmpty(authorsKey))
            {
                var filteredAuthors = authorsList.Where(author => author.FirstName.ToLower().StartsWith(authorsKey)).ToList();

                if (filteredAuthors.Any())
                {
                    Console.WriteLine(authorsKey + " Authors starting with ..:");
                    foreach (var author in filteredAuthors)
                    {
                        Console.WriteLine("Author Firstname: " + author.FirstName + ", AuthorLastname: " + author.LastName);
                    }
                }
                else
                {
                    Console.WriteLine("No one author found.");
                }
            }
            else
            {
                Console.WriteLine("Denied Access.");
            }

            Console.ReadKey();
        }
        else if (secim == "2")
        {
            Console.WriteLine("Please enter the letter for your book selection:");
            string booksKey = Console.ReadLine()?.Trim().ToLower();

            if (!string.IsNullOrEmpty(booksKey))
            {
                var filteredBooks = authorsList
                    .SelectMany(author => author.Books)
                    .Where(book => book.Title.ToLower().StartsWith(booksKey)).ToList();

                if (filteredBooks.Any())
                {
                    Console.WriteLine(booksKey + " books starting with the letter :");
                    foreach (var book in filteredBooks)
                    {
                        var author = authorsList.First(a => a.Books.Contains(book));
                        Console.WriteLine("Books Title: " + book.Title + ", Author: " + author.FirstName + " " + author.LastName + ", Type: " + book.Type + ", Page Count: " + book.PageCount);
                    }
                }
                else
                {
                    Console.WriteLine("Books are not found.");
                }
            }
            else
            {
                Console.WriteLine("Denied Access.");
            }

            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Denied Access.");
            Console.ReadKey();
        }
    }
    #endregion
}
