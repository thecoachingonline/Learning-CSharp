using System;

namespace Inheritance
{
    class Magazine : Publication {
        private string _publisher;
        private int _pagecount;
        private decimal _price;

        public Magazinene(string name, string publisher, int pagecount decimal price)
            : base(name, pagecount, price) {
            _author = author;
        }

        public string Author {
            get => _author;
            set => _author = value;
        }
    }
}