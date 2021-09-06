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
        public void LessThan20()
        {
            CurrencyConverter test = new CurrencyConverter();

            Assert.AreEqual("Zero Dollars And Zero Cents", test.CurrencyToWords(0));
            Assert.AreEqual("One Dollar And One Cent", test.CurrencyToWords(1.01));
            Assert.AreEqual("Two Dollars And One Cent", test.CurrencyToWords(2.01));
            Assert.AreEqual("Three Dollars And Sixtyfive Cents", test.CurrencyToWords(3.65));
            Assert.AreEqual("Four Dollars And Ninetynine Cents", test.CurrencyToWords(4.99));
            Assert.AreEqual("Five Dollars And Ten Cents", test.CurrencyToWords(5.10));
            Assert.AreEqual("Six Dollars And Twentyfive Cents", test.CurrencyToWords(6.25));
            Assert.AreEqual("Seven Dollars And Nineteen Cents", test.CurrencyToWords(7.19));
            Assert.AreEqual("Eight Dollars And Ninetyone Cents", test.CurrencyToWords(8.91));
            Assert.AreEqual("Nine Dollars And Thirtythree Cents", test.CurrencyToWords(9.33));
            Assert.AreEqual("Ten Dollars And Fifty Cents", test.CurrencyToWords(10.50));
            Assert.AreEqual("Eleven Dollars And Seventyseven Cents", test.CurrencyToWords(11.77));
            Assert.AreEqual("Twelve Dollars And Fourty Cents", test.CurrencyToWords(12.4));
            Assert.AreEqual("Thirteen Dollars And Sixtyeight Cents", test.CurrencyToWords(13.68));
            Assert.AreEqual("Fourteen Dollars And One Cent", test.CurrencyToWords(14.01));
            Assert.AreEqual("Fifteen Dollars And Zero Cents", test.CurrencyToWords(15.00));
            Assert.AreEqual("Sixteen Dollars And Eleven Cents", test.CurrencyToWords(16.11));
            Assert.AreEqual("Seventeen Dollars And Eightynine Cents", test.CurrencyToWords(17.89));
            Assert.AreEqual("Eighteen Dollars And Twelve Cents", test.CurrencyToWords(18.12));
            Assert.AreEqual("Nineteen Dollars And Zero Cents", test.CurrencyToWords(19));
        }

        [TestMethod]
        public void Tens()
        {
            CurrencyConverter test = new CurrencyConverter();

            Assert.AreEqual("Twenty Dollars And Zero Cents", test.CurrencyToWords(20));
            Assert.AreEqual("Thirty Dollars And One Cent", test.CurrencyToWords(30.01));
            Assert.AreEqual("Fourtytwo Dollars And Fifty Cents", test.CurrencyToWords(42.50));
            Assert.AreEqual("Fiftynine Dollars And Eightyeight Cents", test.CurrencyToWords(59.88));
            Assert.AreEqual("Sixtythree Dollars And Seventeen Cents", test.CurrencyToWords(63.17));
            Assert.AreEqual("Seventy Dollars And Zero Cents", test.CurrencyToWords(70.00));
            Assert.AreEqual("Eightyfive Dollars And Eightyfive Cents", test.CurrencyToWords(85.85));
            Assert.AreEqual("Ninetynine Dollars And Ninetynine Cents", test.CurrencyToWords(99.99));
        }

        [TestMethod]
        public void Hundreds()
        {
            CurrencyConverter test = new CurrencyConverter();

            Assert.AreEqual("One Hundred Dollars And Zero Cents", test.CurrencyToWords(100));
            Assert.AreEqual("One Hundred Dollars And One Cent", test.CurrencyToWords(100.01));
            Assert.AreEqual("Three Hundred And Fifty Dollars And Seventyfour Cents", test.CurrencyToWords(350.74));
            Assert.AreEqual("Five Hundred And Fiftyfive Dollars And Fiftyfive Cents", test.CurrencyToWords(555.55));
            Assert.AreEqual("Nine Hundred And Ninetynine Dollars And Ninetynine Cents", test.CurrencyToWords(999.99));
        }

        [TestMethod]
        public void Thousands()
        {
            CurrencyConverter test = new CurrencyConverter();

            Assert.AreEqual("One Thousand Dollars And Zero Cents", test.CurrencyToWords(1000.00));
            Assert.AreEqual("One Thousand Dollars And One Cent", test.CurrencyToWords(1000.01));
            Assert.AreEqual("One Thousand And Two Hundred And Thirtyfour Dollars And Fiftysix Cents", test.CurrencyToWords(1234.56));
            Assert.AreEqual("Ninetyeight Thousand And Seven Hundred And Sixtyfive Dollars And Fourtythree Cents", test.CurrencyToWords(98765.43));
            Assert.AreEqual("Nine Hundred And Ninetynine Thousand And Nine Hundred And Ninetynine Dollars And Ninetynine Cents", test.CurrencyToWords(999999.99));
        }

        [TestMethod]
        public void Millions()
        {
            CurrencyConverter test = new CurrencyConverter();

            Assert.AreEqual("One Million Dollars And Zero Cents", test.CurrencyToWords(1000000.00));
            Assert.AreEqual("Fifty Million Dollars And Seventytwo Cents", test.CurrencyToWords(50000000.72));
            Assert.AreEqual("Nine Hundred And Ninetynine Million And Nine Hundred And Ninetynine Thousand And Nine Hundred And Ninetynine Dollars And Ninetynine Cents", test.CurrencyToWords(999999999.99));
        }

        /// <summary>
        /// Testing values in the billions from 1 billion to the max value allowed by int32 which is 2,147,483,647
        /// </summary>
        [TestMethod]
        public void Billions()
        {
            CurrencyConverter test = new CurrencyConverter();

            Assert.AreEqual("One Billion Dollars And Zero Cents", test.CurrencyToWords(1000000000.00));            
            Assert.AreEqual("Two Billion And One Hundred And Fourtyseven Million And Four Hundred And Eightythree Thousand And Six Hundred And Fourtysix Dollars And Fiftyeight Cents", test.CurrencyToWords(2147483646.58));
        }
    }
}