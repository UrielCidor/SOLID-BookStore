using BookLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLib
{
    [Serializable]

    public class SalesPerson : Employee
    {
        public SalesPerson(string name)
        {
            EmployeeName = name;
        }
        public SalesPerson(string name, string address) : base(name, address) { }
        public SalesPerson(string name, string address, DateTime startDate) : base(name, address, startDate, EmployeeType.Salesperson) { }
        protected override bool SaleFromSupply(AbstractItem itemForSale)
        {
            throw new NotImplementedException();
        }
    }
}
