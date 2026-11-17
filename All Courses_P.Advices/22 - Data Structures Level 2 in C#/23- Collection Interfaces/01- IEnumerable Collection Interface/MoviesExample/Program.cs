using System;
using System.Collections;

class Program
{
    public class MovieItem
    {
        public string Title { get; set; }
        public float Rating { get; set; }

        public MovieItem(string title, float rating)
        {
            Title = title;
            Rating = rating;
        }

        public override string ToString()
        {
            return $"Title: {Title}\n" +
                    $"Rating: {Rating}\n";
        }
    }

    public class MovieCollectionEnumerator : IEnumerator
    {
        private MovieItem[] _movieCollection;
        private int _position = -1;

        public MovieCollectionEnumerator(MovieItem[] list)  // constructor
            => _movieCollection = list;

        public bool MoveNext()
        {
            _position++;
            return (_position < _movieCollection.Length);
        }

        public void Reset() => _position = -1;

        object IEnumerator.Current
        {
            get => Current;
        }

        public MovieItem Current
        {
            get => _movieCollection[_position];
        }
    }

    public class MovieCollection : IEnumerable
    {
        private MovieItem[] _movies =
        {
            new MovieItem("Movie 1", 4.9F),
            new MovieItem("Movie 2", 4.5F)
        };

        MovieCollectionEnumerator GetEnumerator()
            => new MovieCollectionEnumerator(_movies);

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }

    public static void Main(string[] args)
    {
        MovieCollection collection = new MovieCollection();

        foreach (var item in collection)
        {
            Console.WriteLine(item.ToString());
        }
    }
}