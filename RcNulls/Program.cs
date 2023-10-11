using RcNulls;

Person? mann = Person.Create("Thomas", "Mann");
Person? aristotle = Person.Create("Aristotle");
Person? bruceEckel = Person.Create("Bruce", "Eckel");

List<Book> books = new()
{
    Book.Create("Doctor Faustus", mann),
    Book.Create("Rhetoric", aristotle),
    Book.Create("One Thousand and One Nights"),
    Book.Create("Thinking in C++", bruceEckel)
};

foreach (var book in books)
{
    Console.WriteLine(Library.GetBookLabel(book));
}





