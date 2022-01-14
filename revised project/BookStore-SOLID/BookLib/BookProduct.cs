using BookLib.Infra;
using System;
using System.Collections.Generic;

namespace BookLib
{
    public class BookProduct : ProductBase, ISearchableBook, ISearchableItem
    {
        
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Publisher { get; private set; }
        public int ISBN { get; private set; }
        public int Edition { get; private set; }
        public DateTime PublishDate { get; private set; }
        public IList<Genre> Genres{ get; set; }

        public string getBookAuthor()
        {
            return Author;
        }

        public int getBookEdition()
        {
            return Edition;
        }

        public IList<Genre> getBookGanares()
        {
            return Genres;
        }

        public int getBookISBN()
        {
            return ISBN;
        }

        public DateTime getBookPublishDate()
        {
            return PublishDate;
        }

        public string getBookPublisher()
        {
            return Publisher;
        }

        public string getBookTitle()
        {
            return Title;
        }

        //public enum Genre { Horror, Advanture, Historical, Biography, Detactive, Science_Fiction, Classic, Noval }
    }

    public class Genre
    {
        public int Id { get; set; }
        public string GenreName { get; set; }
        public IList<BookProduct> Books { get; set; } 
    }
}
