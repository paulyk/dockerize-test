using App.Model;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace App.Server;

public class Query {
    public string Greet => "Have some hot chocolate, it's good!";
    public string Info => "hotchoc server v1";

    public Book GetBook() =>
        new Book {
            Title = "C# in depth.",
        };

    public List<Book> GetBooks() => new List<Book> {
        new Book { Title = "Anitifragile"},
    };
    public List<Book> GetBooks2([Service] DataDb db) => db.GetBooks();

}
