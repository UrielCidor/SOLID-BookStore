using System;
using System.Collections.Generic;
using System.Text;

namespace BookLib.Infra
{
    public interface IProduct
    {
        //change to properties
        string ProductName();
        ProductCategory Category();
        double Price();
        int Quantity();
        double Discount();
        void Validate();
        List<string> GetSearchFields();
    }
}
