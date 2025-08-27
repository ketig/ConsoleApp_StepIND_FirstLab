using ConsoleApp_StepIND_FirstLab.LINQ;

List<Book> books = new List<Book>
        {
            new Book("To Kill a Mockingbird", "Harper Lee", new DateTime(1960, 7, 11)),
            new Book("1984", "George Orwell", new DateTime(1949, 6, 8)),
            new Book("The Great Gatsby", "F. Scott Fitzgerald", new DateTime(1925, 4, 10)),
            new Book("Moby Dick", "Herman Melville", new DateTime(1851, 10, 18)),
            new Book("Pride and Prejudice", "Jane Austen", new DateTime(1813, 1, 28)),
            new Book("The Catcher in the Rye", "J.D. Salinger", new DateTime(1951, 7, 16)),
            new Book("The Lord of the Rings", "J.R.R. Tolkien", new DateTime(1954, 7, 29)),
            new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", new DateTime(1997, 6, 26)),
            new Book("The Hobbit", "J.R.R. Tolkien", new DateTime(1937, 9, 21)),
            new Book("War and Peace", "Leo Tolstoy", new DateTime(1869, 1, 1)),
            new Book("Crime and Punishment", "Fyodor Dostoevsky", new DateTime(1866, 1, 1)),
            new Book("The Brothers Karamazov", "Fyodor Dostoevsky", new DateTime(1880, 1, 1)),
            new Book("Brave New World", "Aldous Huxley", new DateTime(1932, 1, 1)),
            new Book("The Alchemist", "Paulo Coelho", new DateTime(1988, 1, 1)),
            new Book("The Da Vinci Code", "Dan Brown", new DateTime(2003, 3, 18)),
            new Book("The Hunger Games", "Suzanne Collins", new DateTime(2008, 9, 14)),
            new Book("The Fault in Our Stars", "John Green", new DateTime(2012, 1, 10)),
            new Book("Gone Girl", "Gillian Flynn", new DateTime(2012, 6, 5)),
            new Book("The Road", "Cormac McCarthy", new DateTime(2006, 9, 26)),
            new Book("Life of Pi", "Yann Martel", new DateTime(2001, 9, 11))
        };

//გამოიტანეთ ყველა წიგნი რომელიც 2010 წელზე გვიან გამოიცა. 
var recentBooks = books.Where(b => b.PublicationDate.Year > 2010);
Syntax.Print(recentBooks, "Books published after 2010:");

//დაალაგეთ წიგნები ავტორის სახელის მიხედვით.
var sortedByAuthor = books.OrderBy(b => b.Author);
Syntax.Print(sortedByAuthor, "Books sorted by author:");

//დაჯგუფეთ წიგნები გამოცემის წლის მიხედვით.
var groupedByYear = books.GroupBy(b => b.PublicationDate.Year);
Console.WriteLine("Books grouped by publication year:");
foreach (var group in groupedByYear)
{
    Console.WriteLine($"Year: {group.Key}");
    foreach (var book in group)
    {
        Console.WriteLine($"  {book}");
    }
}

//გამოიყენეთ Select რათა მხოლოდ სათაურები გამოიტანონ.
var titles = books.Select(b => b.Title);
Syntax.Print(titles, "Book titles:");
