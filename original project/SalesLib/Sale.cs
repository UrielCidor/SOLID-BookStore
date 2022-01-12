using System;
using System.Collections.Generic;
using System.Text;
using BookLib;
using EmployeeLib;

namespace SalesLib
{
    [Serializable]
    public class Sale
    {
        private static int _currentId;
        public int SaleID { get; private set; }
        public DateTime SaleTime { get; set; }
        public Employee SoldBy { get; set; }
        public double SaleTotal { get; set; }

        public List<AbstractItem> ItemsInSaleList;

        static Sale() => _currentId = 0;
        protected int GetId() => ++_currentId; 

        public Sale(AbstractItem itemInSale, Employee currentEmployee)
        {
            SaleID = GetId();
            ItemsInSaleList = new List<AbstractItem>();
            itemInSale.Quantity = 1;
            ItemsInSaleList.Add(itemInSale);
            SoldBy = currentEmployee;            
        }
        
        public void AddItemToSale(AbstractItem addedItem)
        {
            addedItem.Quantity = 1;
            ItemsInSaleList.Add(addedItem);
        }

        //public void GetTotal(List<AbstractItem> itemsInSale) 
        //{
        //    foreach (var item in itemsInSale)
        //    {
        //        item.Discounts.Sort();
        //        var heighestDiscount = item.Discounts[item.Discounts.Count-1];
        //        SaleTotal += item.Price - (item.Price * (heighestDiscount / 100));
        //    }
        //}
    }
}
