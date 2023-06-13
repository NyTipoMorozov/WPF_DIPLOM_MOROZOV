using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void loginTest()
        {
            string psbPassword = "";
            string txbLogin = "";
            Assert.AreEqual(psbPassword, txbLogin);
        }
    }
}
