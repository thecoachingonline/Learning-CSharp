using System;

namespace Properties
{
    class Book
    {
        private string _name;
        private string _author;
        private int _pagecount;

        public Book(string name, string author, int pages) {
            _name = name;
            _author = author;
            _pagecount = pages;
        }

        public string Name {
            get {
                return _name;
            }
            set {
                _name = value;
            }
        }

        public string Author {
            get => _author;
            set => _author = value;
        }
        public int Pagecount {
            get => _pagecount;
            set => _pagecount = value;
        }

        public string Description {
            get => $"{Name} by {Author}, {Pagecount} pages";
        }

        public string ISBN {
            get; set;
        }
        public decimal Price {
            get; set;
        }
    }
}