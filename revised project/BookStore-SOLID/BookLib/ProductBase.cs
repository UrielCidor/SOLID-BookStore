using BookLib.Infra;
using System.Collections;
using System.Collections.Generic;

namespace BookLib
{
    abstract public class ProductBase : ISearchableItem
    {
        public int Id { get; private set; }
        public string ProductName { get; set; }
        public ProductCategory Category { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }

        public double getItemDiscount()
        {
            return Discount;
        }

        public int getId()
        {
            return Id;
        }

        public double getItemPrice()
        {
            return Price;
        }

        public int getItemQuantity()
        {
            return Quantity;
        }


        public ProductCategory GetCategory()
        {
            return Category;
        }
    }

    public class ProductCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public IList<ProductBase> Products { get; set; }
    }

}
