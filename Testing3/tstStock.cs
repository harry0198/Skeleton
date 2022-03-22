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
            Int32 TestData = 6;
            //assign the data to the property
            Stock.GameID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Stock.GameID, TestData);
        }

        [TestMethod]
        public void GameNameOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Test Name";
            //assign the data to the property
            Stock.GameName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Stock.GameName, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 12;
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
            Stock.Availability = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Stock.Availability, TestData);
        }

        [TestMethod]
        public void ReleaseDateOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            Stock.ReleaseDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Stock.ReleaseDate, TestData);
        }

        [TestMethod]
        public void AgeRatingOK()
        {
            //create an instance of the class we want to create
            clsStock AnAddress = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 12;
            //assign the data to the property
            AnAddress.AgeRating = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.AgeRating, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // Boolean variable to store results of validation
            Boolean Found = false;
            // Create some test data to use with the method
            Int32 GameID = 6;
            // Invoke the method
            Found = AnStock.Find(GameID);
            // Test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestGameIDFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (asume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 GameID = 6;
            //invoke the method
            Found = AnStock.Find(GameID);
            //check the address no
            if (AnStock.GameID != 6)
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestGameNameFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (asume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 GameID = 6;
            //invoke the method
            Found = AnStock.Find(GameID);
            //check the address no
            if (AnStock.GameName != "Test Name")
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (asume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 GameID = 6;
            //invoke the method
            Found = AnStock.Find(GameID);
            //check the address no
            if (AnStock.Price != 12)
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailabilityFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (asume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 GameID = 6;
            //invoke the method
            Found = AnStock.Find(GameID);
            //check the address no
            if (AnStock.Availability != true)
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReleaseDateFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (asume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 GameID = 6;
            //invoke the method
            Found = AnStock.Find(GameID);
            //check the address no
            if (AnStock.ReleaseDate != Convert.ToDateTime("12/12/2022"))
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestAgeRatingFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (asume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 GameID = 6;
            //invoke the method
            Found = AnStock.Find(GameID);
            //check the address no
            if (AnStock.AgeRating != 12)
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }

















    }
}
