using System;
using System.Collections.Generic;
using System.Text;

namespace BibilioteksApp
{
    class Book
    {
        public string name;
        public string author;
        public string releaseDate;
        public string theme;
        public int pages;

        public Book(string name, string author, string releaseDate, string theme, int pages)
        {
            this.name = name;
            this.author = author;
            this.releaseDate = releaseDate;
            this.theme = theme;
            this.pages = pages;
        }
    }
}
