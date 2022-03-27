using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaffValidation
    {
        //good test data
        //create some test data to pass the method
        string StaffID = "1";
        string StaffUsername = "ExampleUser";
        string StaffPassword = "ExamplePass";
        string Role = "Sales";
        string Admin = "true";
        string StartDate = DateTime.Now.Date.ToString();

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
