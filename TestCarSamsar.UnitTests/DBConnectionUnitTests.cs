using CarSamsar;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestCarSamsar.UnitTests
{
    [TestClass]
    public class DBConnectionUnitTests
    {
        [TestMethod]
        public void DBConnection_IsConnected_ReturnsTrue()
        {
            DBConnection.connectionString = "server=sql11.freesqldatabase.com;user=sql11403541;database=sql11403541;port=3306;password=kUFVMDviwp";
            DBConnection.Connect();

            var result = DBConnection.IsConnected();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DBConnection_IsConnected_ReturnsFalse()
        {
            DBConnection.connectionString = "server=s11.freesqldatabase.com;user=sql11403541;database=sql11403541;port=3306;password=kUFVMDviwp";
            DBConnection.Connect();

            var result = DBConnection.IsConnected();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DBConnection_CloseConnection()
        {
            DBConnection.connectionString = "server=sql11.freesqldatabase.com;user=sql11403541;database=sql11403541;port=3306;password=kUFVMDviwp";
            DBConnection.Connect();
            DBConnection.CloseConnection();

            var result = DBConnection.IsConnected();

            Assert.IsFalse(result);
        }
    }
}
