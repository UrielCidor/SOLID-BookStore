using System;
using System.Collections.Generic;
using System.Text;

namespace BookLib
{
    public class JournalProduct : ProductBase
    {
        public string JournalName { get; private set; }
        public string Publisher { get; private set; }
        public DateTime PublishDate { get; private set; }
        public JournalCategory JournalCategory{ get; set; }
        public IList<JournalTopic> Topics { get; set; }
    }
    public class JournalCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<JournalProduct> Journals { get; set; }
    }
    public class JournalTopic
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<JournalProduct> Journals { get; set; }
    }
}
