using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BookLib
{
    
    public class SupplyManager
    {
        const string dir = @".\Data";
        string filePath;
        private List<AbstractItem> SupplyList;

        public SupplyManager()
        {
            SupplyList = new List<AbstractItem>();
            filePath = Path.Combine(dir, "SupplyData.bin");
            InitSupplyList();
        }

        public List<AbstractItem> searchSupplyTitle(string title)
        {
            List<AbstractItem> searchReturnedItems = new List<AbstractItem>();
            foreach (var item in SupplyList)
            {
                Book tmp = item as Book;
                if (tmp.Title == title) searchReturnedItems.Add(tmp);
            }
            return searchReturnedItems;
        }
        public List<AbstractItem> searchSupplyTypes(AbstractItem.Itemtype searchedType)
        {
            List<AbstractItem> searchReturnedItems = new List<AbstractItem>();
            foreach (var item in SupplyList)
            {
                
                if (item.ItemType == searchedType) searchReturnedItems.Add(item);
            }
            return searchReturnedItems;
        }

        public void AddToSupply(AbstractItem supplyItem)
        {
            SupplyList.Add(supplyItem);
            
            using (Stream stream = File.Open(filePath, FileMode.OpenOrCreate))
            {
                var binFormatter = new BinaryFormatter();
                binFormatter.Serialize(stream, SupplyList);
            }
        }
        public void RemoveFromSupply(AbstractItem supplyItem)
        {
            SupplyList.Remove(supplyItem);

            using (Stream stream = File.Open(filePath, FileMode.OpenOrCreate))
            {
                var binFormatter = new BinaryFormatter();
                binFormatter.Serialize(stream, SupplyList);
            }
        }

        public void InitSupplyList()
        {
            try
            {
                using(Stream stream = File.Open(filePath, FileMode.OpenOrCreate))
                {
                    var binFormatter = new BinaryFormatter();
                    if (stream.Length > 0)
                        SupplyList = (List<AbstractItem>)binFormatter.Deserialize(stream);
                }
            }
            catch (FileNotFoundException)
            {
                throw;
            }
        }

        public List<AbstractItem> GetSupply()
        {
            return SupplyList;
        }

        /// <summary>
        /// //
        /// 
        /// 
        /// 
        /// </summary>
        /*static public List<AbstractItem> Supply = new List<AbstractItem>();
        //adding items to supply:
        static void AddBookToSupply(double price, int qunat, string title, string author, string publisher, int isbn, int edition, DateTime publishDate, Ganres ganre)
        { 
            Book tmp = new Book(title, author, publisher, isbn, edition, publishDate, ganre);
            foreach (var item in Supply)
            {
                if (item.GetType() == typeof(Book))
                {
                    if (item.Equals(tmp))
                    {
                        item.Quantity += qunat;
                    }
                    else
                    {
                        Book addedBook = new Book(price, qunat, title, author, publisher, isbn, edition, publishDate, ganre);
                        Supply.Add(addedBook);
                    }
                }
            }
        }
        static void AddJournlToSupply(double price, int qunat, string name, string publisher, DateTime publishDate, Journal.JournalType type, Journal.JournalTopic topic)
        {
            Journal tmp = new Journal(name, publisher, publishDate, type, topic);
            foreach (var item in Supply)
            {
                if (item.GetType() == typeof(Journal))
                {
                    if (item.Equals(tmp))
                    {
                        item.Quantity += qunat;
                       
                    }
                    else
                    {
                        Journal addedJournal = new Journal(price, qunat, name, publisher, publishDate, type, topic);
                        Supply.Add(addedJournal);
                    }
                }
            }

        }
        //Searching and updating items in supply:
        public static bool SearchSupplyByID(int searchedItemID, out AbstractItem foundItem)
        {
            foreach (var item in Supply)
            {
                if(item.ItemId == searchedItemID)
                {
                    foundItem = item;
                    return true;
                }
            }
            foundItem = default;
            return false;
        }
        static bool UpdateItemPrice(AbstractItem updatedItem, double newPrice)
        {
            if (SearchSupplyByID(updatedItem.ItemId, out AbstractItem foudnItem))
            {
                foudnItem.Price = newPrice;
                return true;
            }
            else return false;
        }
        static bool UpdateItemDiscount(AbstractItem updatedItem, int newDiscount)
        {
            if (SearchSupplyByID(updatedItem.ItemId, out AbstractItem foudnItem))
            {
                foudnItem.Discounts.Add(newDiscount);
                return true;
            }
            else return false;
        }
        //Sorting supply list:
        static List<AbstractItem> SortSupplyByPrice()
        {
            Supply.Sort(
                delegate (AbstractItem p1, AbstractItem p2)
                {
                    int comparePrice = p1.Price.CompareTo(p2.Price);
                    if (comparePrice == 0)
                    {
                        return p2.ItemId.CompareTo(p2.ItemId);
                    }
                    return comparePrice;
                });
            return Supply;
        }
        static List<AbstractItem> SortSupplyByQuantity()
        {
            Supply.Sort(
                delegate (AbstractItem p1, AbstractItem p2)
                {
                    int compareQuantity = p1.Quantity.CompareTo(p2.Quantity);
                    if (compareQuantity == 0)
                    {
                        return p2.ItemId.CompareTo(p2.ItemId);
                    }
                    return compareQuantity;
                });
            return Supply;
        }
        //static List<AbstractItem> SortSupplyByDiscount()
        //{
        //    Supply.Sort(
        //        delegate (AbstractItem p1, AbstractItem p2)
        //        {
        //            int comparediscounts = p1.Discount.CompareTo(p2.Discount);
        //            if (comparediscounts == 0)
        //            {
        //                return p2.ItemId.CompareTo(p2.ItemId);
        //            }
        //            return comparediscounts;
        //        });
        //    return Supply;
        //}
        //Removing item from supply:
        static bool RemoveItemFromSupply(AbstractItem removedItem)
        {
            if (SearchSupplyByID(removedItem.ItemId, out AbstractItem itemRemoved))
            {
                foreach (var item in Supply)
                {
                    if (item.ItemId == removedItem.ItemId)
                    {
                        Supply.Remove(item);
                    }
                }
                return true;
            }
            else return false;
        }
        //Selling Items from supply:
       // static bool SaleItemFromSupply(AbstractItem )*/
    }
}
