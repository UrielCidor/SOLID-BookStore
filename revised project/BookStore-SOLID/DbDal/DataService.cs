using BookLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbDal
{
    public class DataService : IDataService
    {
        private readonly Repository repository = new();

        public IList<ProductCategory> GetProductCategories() => repository.ProductCategories;

        public IList<ProductBase> GetProducts() => repository.Products;
        
    }
}
