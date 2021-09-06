using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnleashedSoftwarePractical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnleashedSoftwarePractical.Tests
{
    [TestClass()]
    public class CurrencyConverterTests
    {
        [TestMethod()]
        public void CurrencyToWordsTest()
        {
            CurrencyConverter test = new CurrencyConverter();

            Assert.AreEqual("Zero Dollars And Zero Cents", test.CurrencyToWords(0));
        }
    }
}