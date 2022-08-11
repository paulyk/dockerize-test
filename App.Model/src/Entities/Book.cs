namespace App.Model;

public class Book {
    public Guid Id { get; set; } = new Guid();
    public string? Title { get; set; }
}