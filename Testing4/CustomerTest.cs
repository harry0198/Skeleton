using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            clsCustomer Customer = new clsCustomer();
            Assert.IsNotNull(Customer);
        }
    }
}
