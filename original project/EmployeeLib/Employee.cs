using System;
using System.Collections.Generic;
using System.Text;
using BookLib;

namespace EmployeeLib
{
    [Serializable]

    abstract public class Employee
    {
        public enum EmployeeType
        {
            Manager, Salesperson
        }
        public EmployeeType Employee_Type { get; set; }
        private static int _currentId;
        public int EmployeeId { get; private set; }
        public string  EmployeeName { get; set; }
        public string EmployeeAddress { get; set; }
        public DateTime EmpolyeeStartDate { get; set; }
        public Employee() { }
        
        public Employee(string name)
        {
            EmployeeId = GetId();
            EmployeeName = name;
            
        }
        public Employee(string name, string address) :this(name)
        {
            EmployeeAddress = address;
        }
        public Employee(string name, string address, DateTime startDate, EmployeeType thisType) :this(name, address)
        {
            EmpolyeeStartDate = startDate;
            Employee_Type = thisType;
        }

        static Employee() => _currentId = 0;
        protected int GetId() => ++_currentId;
        protected abstract bool SaleFromSupply(AbstractItem itemForSale);
        
    }
}
