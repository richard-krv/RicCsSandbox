namespace RcNulls;

internal sealed class Library
{
    public static string GetLabel(Person person) => person
        .LastName
        .Map(lastName => $"{person.FirstName} {lastName}")
        .Reduce(person.FirstName);

    public static string GetBookLabel(Book book) => book
        .Author
        .Map(GetLabel)
        .Map(author => $"{book.Title} by {author}")
        .Reduce(book.Title);
}
