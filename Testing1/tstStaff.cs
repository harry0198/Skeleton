using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instancec of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //test to see that this exists
            Assert.IsNotNull(AnStaff);
        }

        [TestMethod]
        public void AdminPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign teh data to the property
            AnStaff.Admin = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Admin, TestData);
        }

        [TestMethod]
        public void StartDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assing to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStaff.StartDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StartDate, TestData);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStaff.StaffID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStaff.StaffID, TestData);
        }

        [TestMethod]
        public void UsernamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "TestUsername";
            //assign the data to the property
            AnStaff.Username = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Username, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "TestPassword";
            AnStaff.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Password, TestData);
        }

        [TestMethod]
        public void RolePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Test Role";
            AnStaff.Role = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Role, TestData);
        }
    }   
        
}
