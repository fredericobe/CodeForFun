using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DateX.Tests
{
    [TestClass]
    public class DateXTests
    {

        [TestMethod]
        public void Test_EndOfFeb()
        {
            var date1 = new DateTime(2022, 2, 25);
            var date2 = new DateTime(2022, 3, 1);

            var expected = 4;

            var diff = new Date.DateX();
            int result = diff.GetDateDiff(date1, date2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_LeapEndOfFeb()
        {
            var date1 = new DateTime(2020, 2, 25);
            var date2 = new DateTime(2020, 3, 1);

            var expected = 5;

            var diff = new Date.DateX();
            int result = diff.GetDateDiff(date1, date2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_BasicDateDiff()
        {
            var date1 = new DateTime(2022, 2, 19);
            var date2 = new DateTime(2022, 2, 20);

            var expected = 1;

            var diff = new Date.DateX();
            int result = diff.GetDateDiff(date1, date2);
            Assert.AreEqual(expected, result);
        }
        
        [TestMethod]
        public void Test_BasicDateDiffNegative()
        {
            var date1 = new DateTime(2022, 2, 19);
            var date2 = new DateTime(2022, 2, 20);

            var expected = -1;

            var diff = new Date.DateX();
            int result = diff.GetDateDiff(date2, date1);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_FullYearDifferenceNegative()
        {
            var date1 = new DateTime(2022, 12, 31);
            var date2 = new DateTime(2022, 1, 1); 

            var expected = -364;

            var diff = new Date.DateX();
            int result = diff.GetDateDiff(date1, date2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_FullYearDifference()
        {
            var date1 = new DateTime(2022, 1, 1);
            var date2 = new DateTime(2022, 12, 31);

            var expected = 364;

            var diff = new Date.DateX();
            int result = diff.GetDateDiff(date1, date2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_FullMonthDifferenceJanuary()
        {
            var date1 = new DateTime(2022, 1, 1);
            var date2 = new DateTime(2022, 1, 31);

            var expected = 30;

            var diff = new Date.DateX();
            int result = diff.GetDateDiff(date1, date2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_FullMonthDifferenceFeb()
        {
            var date1 = new DateTime(2022, 2, 1);
            var date2 = new DateTime(2022, 2, 27);

            var expected = 26;

            var diff = new Date.DateX();
            int result = diff.GetDateDiff(date1, date2);
            Assert.AreEqual(expected, result);
        }



        [TestMethod]
        public void Test_DayOfTheYear()
        {
            var date = new DateTime(2022, 2, 1);

            var expected = 32;

            var diff = new Date.DateX();
            int result = diff.GetDayOfTheYear(date);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_LastDayOfTheYear()
        {
            var date = new DateTime(2022, 12, 31);

            var expected = 365;

            var diff = new Date.DateX();
            int result = diff.GetDayOfTheYear(date);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_DaysInDIfferentYears()
        {
            var date1 = new DateTime(2021, 12, 31);
            var date2 = new DateTime(2022, 1, 1);

            var expected = 1;

            var diff = new Date.DateX();
            int result = diff.GetDateDiff(date1, date2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_DaysIn2YearsNegative()
        {
            var date1 = new DateTime(2022, 12, 31);
            var date2 = new DateTime(2021, 1, 1); 

            var expected = -729;

            var diff = new Date.DateX();
            int result = diff.GetDateDiff(date1, date2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_DaysIn2Years()
        {
            var date1 = new DateTime(2021, 1, 1);
            var date2 = new DateTime(2022, 12, 31); 

            var expected = 729;

            var diff = new Date.DateX();
            int result = diff.GetDateDiff(date1, date2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_DaysIn2YearsWithLeap()
        {
            var date1 = new DateTime(2020, 1, 1);
            var date2 = new DateTime(2021, 12, 31);

            var expected = 730;

            var diff = new Date.DateX();
            int result = diff.GetDateDiff(date1, date2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_DaysIn2Decades()
        {
            var date1 = new DateTime(2000, 1, 1);
            var date2 = new DateTime(2021, 12, 31);

            var expected = 8035;

            var diff = new Date.DateX();
            int result = diff.GetDateDiff(date1, date2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_IsLeapYear()
        {
           
            var expected = true;
            var diff = new Date.DateX();
            var result = diff.IsLeapYear(2020);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_IsNotLeapYear()
        {

            var expected = false;
            var diff = new Date.DateX();
            var result = diff.IsLeapYear(2022);
            Assert.AreEqual(expected, result);
        }
    }
}