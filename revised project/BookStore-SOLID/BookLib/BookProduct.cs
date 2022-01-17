using BookLib.Infra;
using System;
using System.Collections.Generic;

namespace BookLib
{
    public class BookProduct : ProductBase
    {
        
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Publisher { get; private set; }
        public int ISBN { get; private set; }
        public int Edition { get; private set; }
        public DateTime PublishDate { get; private set; }
        public IList<Genre> Genres{ get; set; }

        public override List<string> GetSearchFields()
        {
            List<string> searchFields = new List<string>();
            searchFields.Add("Title");
            searchFields.Add("Author");
            searchFields.Add("Publisher");
            searchFields.Add("ISBN");
            searchFields.Add("Edition");
            searchFields.Add("Published Date");
            searchFields.Add("Genres");

            return searchFields;
        }

    }

    public class Genre
    {
        public int Id { get; set; }
        public string GenreName { get; set; }
        public IList<BookProduct> Books { get; set; } 
    }
}
