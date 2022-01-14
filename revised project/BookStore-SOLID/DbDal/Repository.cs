using BookLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbDal
{
    public class Repository
    {
        private readonly DataContext data = new();

        //public IEnumerable<BookItem> Books => data.Books;
        //public IEnumerable<JournalItem> Journals => data.Journals;

        public void AddBook(BookProduct book)
        {
            //data.Books.Add(book);
            data.SaveChanges();
        }
    }
}
