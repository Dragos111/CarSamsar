using System;
using System.Text;
using System.Collections.Generic;
using System.Collections;
using CarSamsar;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCarSamsar.UnitTests
{
    [TestClass]
    public class LogsUnitTest
    {
        [TestMethod]
        public void Logs_Adds()
        {
            string username = "car";
            string type = "type";
            string attempt = "a";

            string result = username + type + attempt;
            Logs.getLogs().Clear();
            Logs.addLog(username, type, attempt);

            Assert.AreEqual(result, Logs.getLogs()[0]);
        }

        [TestMethod]
        public void Logs_AddUserLog()
        {
            string username = "car";
            string type = "type";
            string attempt = "a";
            string user = "matei";

            string result = username + type + user + attempt;
            Logs.getLogs().Clear();
            Logs.addUserLog(username, type, attempt, user);

            Assert.AreEqual(result, Logs.getLogs()[0]);
        }

        [TestMethod]
        public void Logs_AddCarLog()
        {
            string username = "car";
            string type = "type";
            string attempt = "a";
            string vin = "matei";

            string result = username + type + vin + attempt;
            Logs.getLogs().Clear();
            Logs.addUserLog(username, type, attempt, vin);

            Assert.AreEqual(result, Logs.getLogs()[0]);
        }
    }
}
