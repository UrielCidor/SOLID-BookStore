using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using BookLib;

namespace SalesLib
{
    public class SalesManager
    {
        const string dir = @"./Data";
        string filePath;
        private List<Sale> SalesList;

        public SalesManager()
        {
            SalesList = new List<Sale>();
            filePath = Path.Combine(dir, "SalesData.bin");
            InitSaleList();
        }


        public void AddSale(Sale newSale)
        {
            SalesList.Add(newSale);

            using (Stream stream = File.Open(filePath, FileMode.OpenOrCreate))
            {
                var binFormatter = new BinaryFormatter();
                binFormatter.Serialize(stream, SalesList);
            }
        }

        private void InitSaleList()
        {
            try
            {
                using (Stream stream = File.Open(filePath, FileMode.OpenOrCreate))
                {
                    var binFormatter = new BinaryFormatter();
                    if (stream.Length > 0)
                        SalesList = (List<Sale>)binFormatter.Deserialize(stream);
                }
            }
            catch (FileNotFoundException)
            {
                throw;
            }
        }

        public List<Sale> GetSalesList()
        {
            return SalesList;
        }
    }
}
