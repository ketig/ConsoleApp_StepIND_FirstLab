namespace ConsoleApp_StepIND_FirstLab.LINQ
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublicationDate { get; set; }

        public Book(string title, string author, DateTime year)
        {
            this.Title = title;
            this.Author = author;
            this.PublicationDate = year;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, Publication Date: {PublicationDate.ToShortDateString()}";
        }
    }
}
