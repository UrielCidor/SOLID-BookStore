using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace BookLib
{
    [Serializable]
    
    abstract public class AbstractItem 
    {
        public enum Itemtype { Book, Journal };

        private static int _currentId;
        public int ItemId { get; private set; }
        public Itemtype ItemType { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        //public List<int> Discounts { get; set; }
        public AbstractItem() {}        
        public AbstractItem(double price, int quant, Itemtype thisType)
        {
            ItemId = GetNextId();
            Price = price;
            Quantity = quant;
            ItemType = thisType;
        }
        static AbstractItem() => _currentId = 0;
        protected int GetNextId() => ++_currentId;



       

      
    }

}
