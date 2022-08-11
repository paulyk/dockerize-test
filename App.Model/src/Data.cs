using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;

namespace App.Model;

public class DataDb {

    public DataDb() {}

    public List<Book> GetBooks() =>  new List<Book> {
        new Book { Title = "Anitifragile"},
        new Book { Title = "The Black Swan"},
        new Book { Title = "Fooled by randomness"},
    };
}