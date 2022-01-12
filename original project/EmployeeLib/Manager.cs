using BookLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLib
{
    [Serializable]

    public class Manager : Employee
    {
        public Manager(string name) 
        {
            EmployeeName = name; 
        }
        public Manager(string name, string address) : base(name, address) { }
        public Manager(string name, string address, DateTime startDate) : base(name, address, startDate, EmployeeType.Manager) { }

        protected override bool SaleFromSupply(AbstractItem itemForSale)
        {
            throw new NotImplementedException();
        }
    }
}
