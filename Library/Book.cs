namespace Library
{
    public class Book : LibraryItem
    {
        public string Author { get; private set; }

        public Book(int id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
            IsAvailable = true;
        }

        public override string DisplayInfo()
        {
            return $"{Id}: {Title} by {Author} - {(IsAvailable ? "Available" : "Loaned")}";
        }
    }
}

