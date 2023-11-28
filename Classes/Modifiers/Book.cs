using System;

namespace Modifiers
{
    class Book
    {
        public string _name;

        protected string _author;

        private int _pagecount;

        public Book(string name, string author, int pages) {
            _name = name;
            _author = author;
            _pagecount = pages;
        }

        public string GetName() {
            return _name;
        }
        public void SetName(string s) {
            _name = s;
        }
        public void SetAuthor(string s) {
            _author = s;
        }
        public void SetPagecount(int c) {
            _pagecount = c;
        }
    }
}