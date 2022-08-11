using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;

namespace App.Model;

public class DataDb {

    public DataDb() {}

    public List<Book> GetBooks() =>  new List<Book> {
        new Book { Title = "Anitifragile"},
        new Book { Title = "The Black Swan"},
        new Book { Title = "Fooled by randomness"},
    };
    public List<Author> GetAuthors() =>  new List<Author> {
        new Author { Name = "Nassim Nicholas Taleb"},
        new Author { Name = "Matt Ridley"},
        new Author { Name = "Atul Gowande"},
    };
}