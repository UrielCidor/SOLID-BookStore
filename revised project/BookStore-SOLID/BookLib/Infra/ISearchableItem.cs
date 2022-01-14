using System;
using System.Collections.Generic;
using System.Text;

namespace BookLib.Infra
{
    interface ISearchableItem
    {
        int getId();
        ProductCategory GetCategory();
        double getItemPrice();
        int getItemQuantity();
        double getItemDiscount();
        
    }
}
