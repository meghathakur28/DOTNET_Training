using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryBookManagementSystem
{
    public class Catalog<T> where T: Book
    {
        private List<T> _items = new List<T>();
        private HashSet<string> _isbnSet = new HashSet<string>();
        private SortedDictionary<string, List<T>> _genreIndex = new SortedDictionary<string, List<T>>();

        // Add item with genre indexing
        public bool AddItem(T item)
        {
             if(item == null|| string.IsNullOrWhiteSpace(item.ISBN))
            {
                return false;
            }
             if(_isbnSet.Contains(item.ISBN))
            {
                return false;
            }
             _isbnSet.Add(item.ISBN);
            _items.Add(item);

            if(!_genreIndex.ContainsKey(item.Genre))
            {
                _genreIndex[item.Genre] = new List<T>();
            }
            _genreIndex[item.Genre].Add(item);
            return true;

        }
        // Get books by genre using indexer
        public List<T> this[string genre]
        {
            get
            {
                if(genre == null)
                {
                    return new List<T>();
                }

                if(_genreIndex.ContainsKey(genre))
                {
                    return _genreIndex[genre];
                }

                return new List<T>();
            }
        }

        // Find books using LINQ and lambda expressions
        public IEnumerable<T> FindBooks(Func<T, bool> predicate)
        {
            return _items.Where(predicate);
        }

    }
}
