using System;
using System.Collections.Generic;
using System.Linq;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public string Genre { get; set; }

    public override string ToString()
    {
        return $"{Title} by {Author}, {Year} - {Genre}";
    }
}

class Program
{
    static void Main()
    {
        List<Book> bookInventory = new List<Book>
        {
            new Book { Title = "1984", Author = "George Orwell", Year = 1949, Genre = "Dystopian" },
            new Book { Title = "Brave New World", Author = "Aldous Huxley", Year = 1932, Genre = "Science Fiction" },
            new Book { Title = "Fahrenheit 451", Author = "Ray Bradbury", Year = 1953, Genre = "Dystopian" },
            new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925, Genre = "Classic" },
            new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960, Genre = "Classic" }
        };

        // Filtering
        var dystopianBooks = bookInventory.Where(b => b.Genre == "Dystopian");

        // Projection
        var bookTitles = bookInventory.Select(b => b.Title);

        // Sorting
        var sortedByYear = bookInventory.OrderBy(b => b.Year);
        var sortedByTitleDesc = bookInventory.OrderByDescending(b => b.Title);

        // Grouping
        var booksByGenre = bookInventory.GroupBy(b => b.Genre);

        // Joining
        var additionalBooks = new List<Book>
        {
            new Book { Title = "Animal Farm", Author = "George Orwell", Year = 1945, Genre = "Satire" }
        };
        var joinedBooks = bookInventory.Join(
            additionalBooks,
            b => b.Author,
            a => a.Author,
            (b, a) => new { Title = b.Title, Author = b.Author, Genre = b.Genre, AdditionalTitle = a.Title });

        // Set Operations
        var uniqueGenres = bookInventory.Select(b => b.Genre).Distinct();
        var unionBooks = bookInventory.Select(b => b.Title).Union(additionalBooks.Select(b => b.Title));
        var intersectGenres = bookInventory.Select(b => b.Genre).Intersect(additionalBooks.Select(b => b.Genre));
        var exceptBooks = bookInventory.Select(b => b.Title).Except(additionalBooks.Select(b => b.Title));

        // Element Operations
        var firstBook = bookInventory.First();
        var lastBook = bookInventory.Last();
        var singleBook = bookInventory.Single(b => b.Title == "1984");
        var elementAtSecond = bookInventory.ElementAt(1);

        // Aggregation
        var totalBooks = bookInventory.Count();
        var minYear = bookInventory.Min(b => b.Year);
        var maxYear = bookInventory.Max(b => b.Year);
        var avgYear = bookInventory.Average(b => b.Year);

        // Quantifiers
        var anyDystopian = bookInventory.Any(b => b.Genre == "Dystopian");
        var allBefore2000 = bookInventory.All(b => b.Year < 2000);
        var containsGatsby = bookInventory.Contains(new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925, Genre = "Classic" }, new BookComparer());

        // Partitioning
        var firstTwoBooks = bookInventory.Take(2);
        var skipFirstTwoBooks = bookInventory.Skip(2);

        // Conversion
        var bookArray = bookInventory.ToArray();
        //Console.WriteLine("Book Array: " + string.Join (", ", bookArray[0]));
        var bookList = bookInventory.ToList();
        var bookDictionary = bookInventory.ToDictionary(b => b.Title);

        // Display results
        Console.WriteLine("Dystopian Books: " + string.Join(", ", dystopianBooks));
        Console.WriteLine("Book Titles: " + string.Join(", ", bookTitles));
        Console.WriteLine("Sorted by Year: " + string.Join(", ", sortedByYear));
        Console.WriteLine("Sorted by Title Desc: " + string.Join(", ", sortedByTitleDesc));
        Console.WriteLine("Books by Genre:");
        foreach (var group in booksByGenre)
        {
            Console.WriteLine($"{group.Key}: {string.Join(", ", group)}");
        }
        Console.WriteLine("Joined Books: " + string.Join(", ", joinedBooks));
        Console.WriteLine("Unique Genres: " + string.Join(", ", uniqueGenres));
        Console.WriteLine("Union Books: " + string.Join(", ", unionBooks));
        Console.WriteLine("Intersect Genres: " + string.Join(", ", intersectGenres));
        Console.WriteLine("Except Books: " + string.Join(", ", exceptBooks));
        Console.WriteLine("First Book: " + firstBook);
        Console.WriteLine("Last Book: " + lastBook);
        Console.WriteLine("Single Book: " + singleBook);
        Console.WriteLine("Element at Second Position: " + elementAtSecond);
        Console.WriteLine("Total Books: " + totalBooks);
        Console.WriteLine("Minimum Year: " + minYear);
        Console.WriteLine("Maximum Year: " + maxYear);
        Console.WriteLine("Average Year: " + avgYear);
        Console.WriteLine("Any Dystopian: " + anyDystopian);
        Console.WriteLine("All Before 2000: " + allBefore2000);
        Console.WriteLine("Contains 'The Great Gatsby': " + containsGatsby);
        Console.WriteLine("First Two Books: " + string.Join(", ", firstTwoBooks));
        Console.WriteLine("Skip First Two Books: " + string.Join(", ", skipFirstTwoBooks));
        
        Console.WriteLine("Book List: " + string.Join(", ", bookList));
        Console.WriteLine("Book Dictionary Keys: " + string.Join(", ", bookDictionary.Keys));
    }
}

public class BookComparer : IEqualityComparer<Book>
{
    public bool Equals(Book x, Book y)
    {
        return x.Title == y.Title && x.Author == y.Author && x.Year == y.Year && x.Genre == y.Genre;
    }

    public int GetHashCode(Book obj)
    {
        return obj.Title.GetHashCode() ^ obj.Author.GetHashCode() ^ obj.Year.GetHashCode() ^ obj.Genre.GetHashCode();
    }
}
