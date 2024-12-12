using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    // Поля класу Book
    public string Author { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Title { get; set; }
    public int Year { get; set; }

    // Конструктор для зручності
    public Book(string author, string name, decimal price, string title, int year)
    {
        Author = author;
        Name = name;
        Price = price;
        Title = title;
        Year = year;
    }
}

class Program
{
    static void Main()
    {
        // Створення колекції з 10 об'єктів Book
        List<Book> books = new List<Book>
        {
            new Book("Автор 1", "Програмування на C#", 95, "Програмування на C# для початківців", 2005),
            new Book("Автор 2", "Основи програмування", 80, "Основи програмування", 2006),
            new Book("Автор 3", "Веб-розробка", 120, "Основи веб-розробки", 2007),
            new Book("Автор 4", "Мова програмування Python", 99, "Python для програмістів", 2004),
            new Book("Автор 5", "Алгоритми та структури даних", 150, "Алгоритми та структури даних", 2008),
            new Book("Автор 6", "Java для початківців", 95, "Java програмування", 2005),
            new Book("Автор 7", "Розробка на JavaScript", 60, "JavaScript для веб-розробників", 2005),
            new Book("Автор 8", "Мови програмування", 110, "Основи мов програмування", 2002),
            new Book("Автор 9", "Програмування C++", 100, "C++ для досвідчених", 2006),
            new Book("Автор 10", "Розробка на C#", 85, "C# для розробників", 2004)
        };

        // Запит LINQ для вибору книг за тематикою Програмування, роком видання не пізніше 2006 і ціною не більше 100 грн
        var filteredBooks = books.Where(b => b.Title.Contains("Програмування")
                                              && b.Year <= 2006
                                              && b.Price <= 100)
                                 .OrderBy(b => b.Author)
                                 .ToList();

        // Виведення відфільтрованих книг
        Console.WriteLine("Книги, що задовольняють умови:");
        foreach (var book in filteredBooks)
        {
            Console.WriteLine($"{book.Author} - {book.Title} ({book.Year}) - {book.Price} грн");
        }

        // Знаходимо найдорожчу книгу
        var mostExpensiveBook = books.OrderByDescending(b => b.Price).First();

        // Виведення найдорожчої книги
        Console.WriteLine("\nНайдорожча книга:");
        Console.WriteLine($"{mostExpensiveBook.Author} - {mostExpensiveBook.Title} ({mostExpensiveBook.Year}) - {mostExpensiveBook.Price} грн");
    }
}
