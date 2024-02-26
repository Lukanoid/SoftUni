using System.Collections;
using System.Diagnostics;
using System.Text;

namespace IteratorsAndComparators;

public class Library : IEnumerable<Book>
{
    private List<Book> books;

    public Library(params Book[] books)
    {
        this.books = new List<Book>(books);
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return new LibraryIterator(books.OrderBy(b=>b, new BookComparator()).ToList());
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }


    private class LibraryIterator : IEnumerator<Book>
    {
        private int currentIndex = -1;
        private readonly List<Book> books;

        public LibraryIterator(List<Book> books)
        {
            this.books = books;
        }
        public bool MoveNext()
        {
            return ++currentIndex < books.Count;
        }

        public void Reset()
        {
            currentIndex = -1;
        }

        public Book Current
        {
            get => books[currentIndex];
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}