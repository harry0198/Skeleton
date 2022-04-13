using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;


namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStock = new clsStockCollection();


            List<clsStock> TestList = new List<clsStock>();


            clsStock TestItem = new clsStock();

            TestItem.GameID = 6;
            TestItem.GameName = "Test Name";
            TestItem.Price = 12;
            TestItem.Availability = true;
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.AgeRating = 12;

            TestList.Add(TestItem);

            AllStock.StockList = TestList;

            Assert.AreEqual(AllStock.StockList, TestList);
        }

        

        [TestMethod]
        public void ThisStockOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            clsStock TestStock = new clsStock();

            TestStock.GameID = 6;
            TestStock.GameName = "Test Name";
            TestStock.Price = 12;
            TestStock.Availability = true;
            TestStock.ReleaseDate = DateTime.Now.Date;
            TestStock.AgeRating = 12;

            AllStock.ThisStock = TestStock;

            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStock = new clsStockCollection();


            List<clsStock> TestList = new List<clsStock>();


            clsStock TestItem = new clsStock();

            TestItem.GameID = 6;
            TestItem.GameName = "Test Name";
            TestItem.Price = 12;
            TestItem.Availability = true;
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.AgeRating = 12;

            TestList.Add(TestItem);

            AllStock.StockList = TestList;

            Assert.AreEqual(AllStock.Count, TestList.Count);
        }












    }
}
