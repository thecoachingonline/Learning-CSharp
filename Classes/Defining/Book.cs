using System;

namespace Defining
{
    public class Book
    {
        string _name;
        string _author;
        int _pagecount;

        public Book(string name, string author, int pages) {
            _name = name;
            _author = author;
            _pagecount = pages;
        }

        public string GetDescription() {
            return $"{_name} by {_author}";
        }
    }
}