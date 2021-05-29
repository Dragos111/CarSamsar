using System;
using System.Text;
using System.Collections.Generic;
using CarSamsar;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCarSamsar.UnitTests
{
    [TestClass]
    public class CheckInputsUnitTests
    {
        [TestMethod]
        public void CheckInputs_CheckUsernamePassword_ReturnsTrue()
        {
            string text = "Matei";
            var result = CheckInputs.CheckUsernamePassword(text);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckInputs_CheckUsernamePassword_ReturnsFalse()
        {
            string text = "123456789123456789123456";
            var result = CheckInputs.CheckUsernamePassword(text);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckInputs_CheckSalary_ReturnsTrue()
        {
            string salary = "3500";
            var result = CheckInputs.CheckSalary(salary);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckInputs_CheckSalary_ReturnsFalse()
        {
            string salary = "3.500";
            var result = CheckInputs.CheckSalary(salary);

            Assert.IsFalse(result);
        }
    }
}
