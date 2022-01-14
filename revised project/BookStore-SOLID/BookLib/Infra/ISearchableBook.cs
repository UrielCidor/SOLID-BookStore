using System;
using System.Collections.Generic;
using System.Text;
using static BookLib.BookProduct;

namespace BookLib.Infra
{
    interface ISearchableBook
    {
        string getBookTitle();
        string getBookAuthor();
        string getBookPublisher();
        int getBookISBN();
        int getBookEdition();
        DateTime getBookPublishDate();
        IList<Genre> getBookGanares();
    }
}
