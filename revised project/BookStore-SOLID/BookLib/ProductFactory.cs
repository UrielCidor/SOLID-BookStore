using BookLib.Infra;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookLib
{
    public class ProductFactory
    {
        public IProduct Create(int productCategoryId)
        {
            if(productCategoryId == 1)
            {
                return new BookProduct();
            }
            else
            {
                return new JournalProduct();
            }
        }
    }
}
