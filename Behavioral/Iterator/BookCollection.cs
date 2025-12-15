namespace DesignPatterns.Behavioral.Iterator;

public class BookCollection
{
    private readonly List<Book> _list = new();

    public void Add(Book book) => _list.Add(book);

    // Factory method for iterator
    public IIterator<Book> CreateIterator()
        => new BookIterator(this);

    private class BookIterator : IIterator<Book>
    {
        private readonly BookCollection _books;
        private int _index = 0;

        public BookIterator(BookCollection books)
            => _books = books;

        public bool HasNext()
            => _index < _books._list.Count;

        public Book Next()
        {
            if (!HasNext())
                throw new InvalidOperationException("No more books.");

            return _books._list[_index++];
        }
    }
}
