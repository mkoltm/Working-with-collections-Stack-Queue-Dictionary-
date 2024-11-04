using System;
using System.Collections.Generic;


// ЗАВДАННЯ 1 (Керування стеком документів)


class Program
{
    static void Main()
    {
        // Створення стеку для документів
        Stack<Document> documentStack = new Stack<Document>();

        // Додавання документів до стеку
        AddDocumentToStack(documentStack, new Document("Document1", "Content1"));
        AddDocumentToStack(documentStack, new Document("Document2", "Content2"));
        AddDocumentToStack(documentStack, new Document("Document3", "Content3"));

        // Виведення інформації про верхній документ у стеці
        PrintTopDocumentInfo(documentStack);

        // Видалення верхнього документу зі стеку
        RemoveTopDocument(documentStack);

        // Виведення інформації про новий верхній документ у стеці
        PrintTopDocumentInfo(documentStack);
    }

    // Функція для додавання нового документу до стеку
    static void AddDocumentToStack(Stack<Document> stack, Document document)
    {
        stack.Push(document);
        Console.WriteLine($"Документ \"{document.Title}\" додано до стеку.");
    }

    // Функція для видалення верхнього документу зі стеку
    static void RemoveTopDocument(Stack<Document> stack)
    {
        if (stack.Count > 0)
        {
            Document removedDocument = stack.Pop();
            Console.WriteLine($"Верхній документ \"{removedDocument.Title}\" видалено зі стеку.");
        }
        else
        {
            Console.WriteLine("Стек документів порожній. Неможливо видалити документ.");
        }
    }

    // Функція для отримання верхнього документу зі стеку без його видалення
    static void PrintTopDocumentInfo(Stack<Document> stack)
    {
        if (stack.Count > 0)
        {
            Document topDocument = stack.Peek();
            Console.WriteLine($"Інформація про верхній документ: {topDocument}");
        }
        else
        {
            Console.WriteLine("Стек документів порожній. Неможливо отримати інформацію.");
        }
    }
}

// Клас, що представляє документ
class Document
{
    public string Title { get; set; }
    public string Content { get; set; }

    public Document(string title, string content)
    {
        Title = title;
        Content = content;
    }

    public override string ToString()
    {
        return $"Назва: {Title}, Вміст: {Content}";
    }
}