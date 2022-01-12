using System;
using System.Collections.Generic;
using System.Text;

namespace BookLib
{
    [Serializable]
    public class Journal : AbstractItem
    {
        public string JournalName { get; private set; }
        public string Publisher { get; private set; }
        public DateTime PublishDate { get; private set; }
        public JournalType Type { get; set; }
        public enum JournalType { NewsPaper, Magazine, Periodical, Comics }
        public JournalType[] JournalTypes { get; set; }
        public string journalTypeListView { get; set; }
        
        public enum JournalTopic { Fashion, Economics, Sceince, Enterteinment, News, Kids, Proffessional }
        public JournalTopic[] JournalTopics { get; set; }
        public string journalTopicsListView { get; set; }

        public Journal(double price, int quant, string name, string publisher, DateTime publishDate, JournalType[] types, JournalTopic[] topics, string typeView, string topicView) : base(price, quant, Itemtype.Journal)
        {
            JournalName = name;
            Publisher = publisher;
            PublishDate = publishDate;
            JournalTypes = types;
            JournalTopics = topics;
            journalTypeListView = typeView;
            journalTopicsListView = topicView;
        }
        public Journal(string name, string publisher, DateTime publishDate, JournalType[] types, JournalTopic[] topics) : base()
        {
            JournalName = name;
            Publisher = publisher;
            PublishDate = publishDate;
            JournalTypes = types;
            JournalTopics = topics;
            //ItemType = Itemtype.Journal;
        }
    }
}
