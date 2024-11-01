namespace Library
{
    public abstract class LibraryItem
{
    public int Id { get; protected set; }
    public string Title { get; protected set; }
        public bool IsAvailable { get; set; }


        public abstract string DisplayInfo();
}
}

