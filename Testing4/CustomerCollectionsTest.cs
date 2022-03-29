using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testing4
{
    [TestClass]
    public class CustomerCollectionsTest
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();

            TestItem.Active = true;
            TestItem.ID = 1;
            TestItem.Password = "Pass";
            TestItem.Username = "Username";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Address = "LE2 3AB";

            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;

            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();

            TestItem.Active = true;
            TestItem.ID = 1;
            TestItem.Password = "Pass";
            TestItem.Username = "Username";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Address = "LE2 3AB";


            AllCustomers.ThisCustomer = TestItem;

            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();

            clsCustomer TestItem = new clsCustomer();
            TestItem.Active = true;
            TestItem.ID = 1;
            TestItem.Password = "Pass";
            TestItem.Username = "Username";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Address = "LE2 3AB";

            TestList.Add(TestItem);

            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
    }
}
