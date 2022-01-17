using BookLib;
using DbDal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace TestProject1
{
    [TestClass]
    public class DALtests
    {
        [TestMethod]
        public void DataAccessTest()
        {

            //Arrange
            //DataContext data = new DataContext();
            int expected = 1;

            var context = new DataContext();
            var category = context.ProductCategories
                                .Where(c => c.CategoryName != null).ToList();
            //act
            var q = category.Find(c => c.CategoryName == "Book");
            //Assert
            int actiual = q.Id;
            Assert.AreEqual(expected, actiual, "dal not working");
        }

        [TestMethod]
        public void RepositoryTest()
        {
            //arrange:
            var repo = new Repository();
            var categories = repo.ProductCategories.ToList();
            int expected = 2;

            //act
            int actual = categories.Count;
            Assert.AreEqual(expected, actual, 0, "repo not working");
        }

        [TestMethod]
        public void DataServiceTest()
        {

            var service = new DataService();
            var productList = service.GetProducts();
            int expected = 4;
            int actual = productList.Count;
            Assert.AreEqual(expected, actual, 0, "data service not working");
        }
    }
}
