using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;


namespace Testing1
{   
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an isntance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Admin = true;
            TestItem.StaffID = 1;
            TestItem.Username = "User1";
            TestItem.Password = "Pass1";
            TestItem.Role = "StartingRole";
            TestItem.StartDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //ser the properties of the test object
            TestStaff.Admin = true;
            TestStaff.StaffID = 1;
            TestStaff.Username = "User1";
            TestStaff.Password = "Pass1";
            TestStaff.Role = "StartingRole";
            TestStaff.StartDate = DateTime.Now.Date;
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data neess to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Admin = true;
            TestItem.StaffID = 1;
            TestItem.Username = "User1";
            TestItem.Password = "Pass1";
            TestItem.Role = "StartingRole";
            TestItem.StartDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of teh class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Admin = true;
            TestItem.StaffID = 1;
            TestItem.Username = "User1";
            TestItem.Password = "Pass1";
            TestItem.Role = "StartingRole";
            TestItem.StartDate = DateTime.Now.Date;
            //set thisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key to the test data
            TestItem.StaffID = PrimaryKey;
            //find the record 
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see taht the two values are the same 
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Admin = true;
            TestItem.StaffID = 1;
            TestItem.Username = "TestUser";
            TestItem.Password = "TestPass";
            TestItem.Role = "TestRole";
            TestItem.StartDate = DateTime.Now.Date;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data 
            TestItem.StaffID = PrimaryKey;
            //modify the test data
            TestItem.Admin = false;
            TestItem.StaffID = 2;
            TestItem.Username = "TestUser2";
            TestItem.Password = "TestPass2";
            TestItem.Role = "TestRole2";
            TestItem.StartDate = DateTime.Now.Date;
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see ThisStaff matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Admin = true;
            TestItem.StaffID = 1;
            TestItem.Username = "User1";
            TestItem.Password = "Pass1";
            TestItem.Role = "TestRole1";
            TestItem.StartDate = DateTime.Now.Date;
            //set this staff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data 
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByUserMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string (should return all records)
            FilteredStaff.ReportByUser("");
            //test to see that te two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);

        }

        [TestMethod]
        public void ReportByUserNoneFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a post code that doesn't exist
            FilteredStaff.ReportByUser("NonExsitantUser");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByUserTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //var to store the outcome
            Boolean OK = true;
            //apply a post code that doesn't exist
            FilteredStaff.ReportByUser("ExampleStaff");
            //check that the correct number of records are found
            if (FilteredStaff.Count == 2)
            {
                //check that the first record is ID 1
                if (FilteredStaff.StaffList[0].StaffID != 1)
                {
                    OK = false;
                }
                //check that the first record is ID 2
                if (FilteredStaff.StaffList[1].StaffID != 2)
                {
                    OK = false;
                }
            }
            
            //test to see that there are no record
            Assert.IsTrue(OK);
        }
    }
}
