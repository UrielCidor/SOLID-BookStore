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
        private readonly DataContext data = new DataContext();
        
        public IList<ProductBase> Products => data.Products.ToList();
        public IList<ProductCategory> ProductCategories => data.ProductCategories.ToList();
   

        public void AddProduct(ProductBase product)
        {
            data.Products.Add(product);
            data.SaveChanges();
        }
        public void DeleteProduct(ProductBase product)
        {
            data.Products.Remove(product);
            data.SaveChanges();
        }
    }
}
