using System;
using System.Text;
using System.Collections.Generic;
using CarSamsar;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCarSamsar.UnitTests
{
    /// <summary>
    /// Summary description for CnpValidatorUnitTestscs
    /// </summary>
    [TestClass]
    public class CnpValidatorUnitTestscs
    {
        [TestMethod]
        public void CnpValidator_IsValidCnp_ReturnsTrue()
        {
            string cnp = "1980926205564";
            var result = CnpValidator.IsValidCnp(cnp);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CnpValidator_IsValidCnp_ReturnsFalse()
        {
            string cnp = "1980926205563";
            var result = CnpValidator.IsValidCnp(cnp);

            Assert.IsFalse(result);
        }
    }
}
