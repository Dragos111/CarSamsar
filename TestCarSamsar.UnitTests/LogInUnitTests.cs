using CarSamsar;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;

namespace TestCarSamsar.UnitTests
{
    [TestClass]
    public class LogInUnitTests
    {
        [TestMethod]
        public void LogIn_LogInAttempt_ReturnsDBConnectionFailed()
        {
            DBConnection.connectionString = "server=s11.freesqldatabase.com;user=sql11403541;database=sql11403541;port=3306;password=kUFVMDviwp";
            DBConnection.Connect();

            var login = new LogIn("test", "test");

            var result = login.LogInAttempt();

            Assert.AreEqual("DB connection failed", result);
        }

        [TestMethod]
        public void LogIn_LogInAttempt_ReturnsSuccessful()
        {
            DBConnection.connectionString = "server=sql11.freesqldatabase.com;user=sql11403541;database=sql11403541;port=3306;password=kUFVMDviwp";
            DBConnection.Connect();

            var login = new LogIn("pavel", "pavel");

            var result = login.LogInAttempt();

            Assert.AreEqual("Successful", result);
        }

        [TestMethod]
        public void LogIn_LogInAttempt_ReturnsFailed()
        {
            DBConnection.connectionString = "server=sql11.freesqldatabase.com;user=sql11403541;database=sql11403541;port=3306;password=kUFVMDviwp";
            DBConnection.Connect();

            var login = new LogIn("pavel", "abc");

            var result = login.LogInAttempt();

            Assert.AreEqual("Failed", result);
        }

        [TestMethod]
        public void LogIn_LogInAttemptAdmin_ReturnsDBConnectionFailed()
        {
            DBConnection.connectionString = "server=s11.freesqldatabase.com;user=sql11403541;database=sql11403541;port=3306;password=kUFVMDviwp";
            DBConnection.Connect();

            var login = new LogIn("test", "test");

            var result = login.LogInAttemptAdmin();

            Assert.AreEqual("DB connection failed", result);
        }

        [TestMethod]
        public void LogIn_LogInAttemptAdmin_ReturnsFailed()
        {
            DBConnection.connectionString = "server=sql11.freesqldatabase.com;user=sql11403541;database=sql11403541;port=3306;password=kUFVMDviwp";
            DBConnection.Connect();

            var login = new LogIn("test", "test");

            var result = login.LogInAttemptAdmin();

            Assert.AreEqual("Failed", result);
        }

        [TestMethod]
        public void LogIn_LogInAttemptAdmin_ReturnsSuccessful()
        {
            DBConnection.connectionString = "server=sql11.freesqldatabase.com;user=sql11403541;database=sql11403541;port=3306;password=kUFVMDviwp";
            DBConnection.Connect();

            var login = new LogIn("admin", "admin");

            var result = login.LogInAttemptAdmin();

            Assert.AreEqual("Successful", result);
        }
    }
}
