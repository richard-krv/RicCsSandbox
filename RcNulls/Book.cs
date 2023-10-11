namespace RcNulls;

internal class Book
{
    public string Title { get; }
    public Option<Person> Author { get; }

    public Book(string title, Option<Person> author) => (Title, Author) = (title, author);

    public static Book Create(string title, Person author) => new(title, Option<Person>.Some(author));
    public static Book Create(string title) => new(title, Option<Person>.None());
}
