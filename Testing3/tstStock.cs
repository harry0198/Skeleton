using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
    [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(Stock);
        }

        [TestMethod]
        public void GameIdOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 45;
            //assign the data to the property
            Stock.gameID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Stock.gameID, TestData);
        }

        [TestMethod]
        public void GameNameOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Basketball";
            //assign the data to the property
            Stock.GameNm = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Stock.GameNm, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 45;
            //assign the data to the property
            Stock.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Stock.Price, TestData);
        }

        [TestMethod]
        public void AvailabilityOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            Stock.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Stock.Active, TestData);
        }

        [TestMethod]
        public void ReleaseDateOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            Stock.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Stock.DateAdded, TestData);
        }

        [TestMethod]
        public void AgeRatingOK()
        {
            //create an instance of the class we want to create
            clsStock AnAddress = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 7;
            //assign the data to the property
            AnAddress.AgeRat = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.AgeRat, TestData);
        }

    }
}
