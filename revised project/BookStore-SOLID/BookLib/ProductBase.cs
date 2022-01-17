using BookLib.Infra;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;

namespace BookLib
{
    abstract public class ProductBase : IProduct
    {
        public int Id { get; private set; }
        public string ProductName { get; set; }
        public ProductCategory Category { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }

        public abstract List<string> GetSearchFields();

        public void Validate()
        {
            throw new System.NotImplementedException();
        }

        ProductCategory IProduct.Category()
        {
            throw new System.NotImplementedException();
        }

        double IProduct.Discount()
        {
            throw new System.NotImplementedException();
        }

        double IProduct.Price()
        {
            throw new System.NotImplementedException();
        }

        string IProduct.ProductName()
        {
            throw new System.NotImplementedException();
        }

        int IProduct.Quantity()
        {
            throw new System.NotImplementedException();
        }
    }

    public class ProductCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public virtual ObservableCollection<ProductBase> Products { get; private set; }
    }

}
