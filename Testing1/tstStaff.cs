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
    }
}
