//ЗАВДАННЯ 3 (Магазин книг зі словником книг)



class Program
{
    static void Main()
    {
        // Створення словника для каталогу книг
        Dictionary<int, Book> bookCatalog = new Dictionary<int, Book>();

        // Додавання книг до словника
        AddBookToCatalog(bookCatalog, new Book(1, "The Great Gatsby", "F. Scott Fitzgerald"));
        AddBookToCatalog(bookCatalog, new Book(2, "To Kill a Mockingbird", "Harper Lee"));
        AddBookToCatalog(bookCatalog, new Book(3, "1984", "George Orwell"));

        // Отримання інформації про книгу за її унікальним ідентифікатором та виведення на екран
        PrintBookInfo(bookCatalog, 2);

        // Видалення книги зі словника за її унікальним ідентифікатором
        RemoveBookFromCatalog(bookCatalog, 1);

        // Виведення всіх книг у каталозі
        PrintAllBooks(bookCatalog);
    }

    // Функція для додавання нової книги до словника
    static void AddBookToCatalog(Dictionary<int, Book> catalog, Book book)
    {
        catalog.Add(book.Id, book);
        Console.WriteLine($"Книга \"{book.Title}\" додана до каталогу.");
    }

    // Функція для видалення книги зі словника за її унікальним ідентифікатором
    static void RemoveBookFromCatalog(Dictionary<int, Book> catalog, int bookId)
    {
        if (catalog.ContainsKey(bookId))
        {
            catalog.Remove(bookId);
            Console.WriteLine($"Книгу з ідентифікатором {bookId} видалено з каталогу.");
        }
        else
        {
            Console.WriteLine($"Книги з ідентифікатором {bookId} не знайдено в каталозі.");
        }
    }

    // Функція для отримання інформації про книгу зі словника за її унікальним ідентифікатором та виведення на екран
    static void PrintBookInfo(Dictionary<int, Book> catalog, int bookId)
    {
        if (catalog.ContainsKey(bookId))
        {
            Book book = catalog[bookId];
            Console.WriteLine($"Інформація про книгу з ідентифікатором {bookId}: {book}");
        }
        else
        {
            Console.WriteLine($"Книги з ідентифікатором {bookId} не знайдено в каталозі.");
        }
    }

    // Функція для виведення всіх книг у каталозі
    static void PrintAllBooks(Dictionary<int, Book> catalog)
    {
        Console.WriteLine("Усі книги у каталозі:");
        foreach (var book in catalog.Values)
        {
            Console.WriteLine(book);
        }
    }
}

// Клас, що представляє книгу
class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(int id, string title, string author)
    {
        Id = id;
        Title = title;
        Author = author;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Назва: {Title}, Автор: {Author}";
    }
}