using System;
using CarSamsar;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCarSamsar.UnitTests
{
    [TestClass]
    public class AdminLoginUnitTests
    {
        [TestMethod]
        public void AdminLogin_RegisterAttempt_ReturnsDBConnectionFailed()
        {
            DBConnection.connectionString = "server=sql11.freesqldatabase.com;user=sql11415485;database=sql11415485;port=3306;password=IfrqccnCZ";
            DBConnection.Connect();

            var adminLogin = new AdminLogin("matei", "matei", "matei", "matei", "12345", "a", "1234");

            var result = adminLogin.RegisterAttempt();

            Assert.AreEqual("DB connection failed", result);
        }

        public void AdminLogin_RegisterAttempt_ReturnsUsernameAlreadyTaken()
        {
            DBConnection.connectionString = "server=sql11.freesqldatabase.com;user=sql11415485;database=sql11415485;port=3306;password=IfrqccnCZi";
            DBConnection.Connect();

            var adminLogin = new AdminLogin("matei", "matei", "matei", "matei", "12345", "a", "1234");

            var result = adminLogin.RegisterAttempt();

            Assert.AreEqual("DB connection failed", result);
        }
    }
}
