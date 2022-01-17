using BookLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbDal
{
    public interface IDataService
    {
        IList<ProductCategory> GetProductCategories();
        IList<ProductBase> GetProducts();
    }
}
