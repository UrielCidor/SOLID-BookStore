using System;
using System.Collections.Generic;
using System.Text;

namespace BookLib
{
    [Serializable]
    
    public class Book : AbstractItem
    {
        public enum Ganres { Horror, Advanture, Historical, Biography, Detactive, Science_Fiction, Classic, Noval }

        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Publisher { get; private set; }
        public int ISBN { get; private set; }
        public int Edition { get; private set; }
        public DateTime PublishDate { get; private set; }
        public Ganres[] Ganares { get; set; }

        public string GanaresListView { get; set; }

        public Book(string title, string author, string publisher, int isbn, int edition, DateTime publishDate/*, List<Ganres> ganres*/) : base()
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ISBN = isbn;
            Edition = edition;
            PublishDate = publishDate;
            //Ganares = ganres;
            //ItemType = Itemtype.Book;
        }
        public Book(double price, int quant, string title, string author, string publisher, int isbn, int edition, DateTime publishDate, Ganres[] ganres, string ganresListView) : base(price, quant, Itemtype.Book)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ISBN = isbn;
            Edition = edition;
            PublishDate = publishDate;
            Ganares = ganres;
            GanaresListView = ganresListView;
            
        }
       


    }
}
