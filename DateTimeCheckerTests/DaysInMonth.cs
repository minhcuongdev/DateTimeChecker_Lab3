using NUnit.Framework;
using DateTimeChecker;

namespace DateTimeCheckerTests
{
    public class DaysInMonth
    {
        private DTChecker dtChecker;
        public DTChecker DtChecker { get => dtChecker; set => dtChecker = value; }

        [SetUp]
        public void Setup()
        {
            DtChecker = new DTChecker();
        }

        [Test]
        public void Test_Days_In_January_Month()
        {
            Assert.AreEqual(31, DtChecker.DaysInMonth(1, 2021));
        }

        [Test]
        public void Test_Days_In_February_Month_With_Normal_Year()
        {
            Assert.AreEqual(28, DtChecker.DaysInMonth(2, 2021));
        }

        [Test]
        public void Test_Days_In_February_Month_With_Leap_Year()
        {
            Assert.AreEqual(29, DtChecker.DaysInMonth(2, 2020));
        }

        [Test]
        public void Test_Days_In_March_Month()
        {
            Assert.AreEqual(31, DtChecker.DaysInMonth(3, 2021));
        }

        [Test]
        public void Test_Days_In_April_Month()
        {
            Assert.AreEqual(30, DtChecker.DaysInMonth(4, 2021));
        }

        [Test]
        public void Test_Days_In_May_Month()
        {
            Assert.AreEqual(31, DtChecker.DaysInMonth(5, 2021));
        }

        [Test]
        public void Test_Days_In_June_Month()
        {
            Assert.AreEqual(30, DtChecker.DaysInMonth(6, 2021));
        }

        [Test]
        public void Test_Days_In_July_Month()
        {
            Assert.AreEqual(31, DtChecker.DaysInMonth(7, 2021));
        }

        [Test]
        public void Test_Days_In_August_Month()
        {
            Assert.AreEqual(31, DtChecker.DaysInMonth(8, 2021));
        }

        [Test]
        public void Test_Days_In_September_Month()
        {
            Assert.AreEqual(30, DtChecker.DaysInMonth(9, 2021));
        }

        [Test]
        public void Test_Days_In_October_Month()
        {
            Assert.AreEqual(31, DtChecker.DaysInMonth(10, 2021));
        }

        [Test]
        public void Test_Days_In_November_Month()
        {
            Assert.AreEqual(30, DtChecker.DaysInMonth(11, 2021));
        }

        [Test]
        public void Test_Days_In_December_Month()
        {
            Assert.AreEqual(31, DtChecker.DaysInMonth(12, 2021));
        }
    }
}