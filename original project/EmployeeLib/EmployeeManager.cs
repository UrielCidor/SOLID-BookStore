using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace EmployeeLib
{
    public class EmployeeManager
    {
        const string dir = @".\Data";
        string filePath;
        public List<Employee> EmployeeList;

        public EmployeeManager()
        {
            EmployeeList = new List<Employee>();
            filePath = Path.Combine(dir, "EmployeeData.bin");
            InitEmployeeList();
        }

        public void AddEmployee(Employee newEmployee)
        {
            EmployeeList.Add(newEmployee);

            using (Stream stream = File.Open(filePath, FileMode.OpenOrCreate))
            {
                var binFormatter = new BinaryFormatter();
                binFormatter.Serialize(stream, EmployeeList);
            }
        }

        public void InitEmployeeList()
        {
            try
            {
                using (Stream stream = File.Open(filePath, FileMode.OpenOrCreate))
                {
                    var binFormatter = new BinaryFormatter();
                    if (stream.Length > 0)
                        EmployeeList = (List<Employee>)binFormatter.Deserialize(stream);
                }
            }
            catch (FileNotFoundException)
            {
                throw;
            }
        }

        public List<Employee> GetEmployeeList()
        {
            return EmployeeList;
        }

        //public static void EnterNewSalesPerson(string name, string address, DateTime startDate)
        //{
        //    EmployeeList.Add(new SalesPerson(name, address, startDate));
        //}
        //public static void EnterNewManager(string name, string address, DateTime startDate)
        //{
        //    EmployeeList.Add(new Manager(name, address, startDate));
        //}
    }
}
