using NUnit.Framework;
using DateTimeChecker;

namespace DateTimeCheckerTests
{
    public class CheckInput
    {
        private DTChecker dtChecker;
        public DTChecker DtChecker { get => dtChecker; set => dtChecker = value; }

        [SetUp]
        public void Setup()
        {
            DtChecker = new DTChecker();
        }

        /// <summary>
        /// if incorrect day, return 1
        /// if incorrect month, return 2
        /// if incorrect year, return 3
        /// if correct, return 0
        /// </summary>

        [Test]
        public void Test_Day_Format_Input()
        {
            Assert.AreEqual(1, DtChecker.CheckFormatInput("ada", "1","2021"));
            Assert.AreEqual(0, DtChecker.CheckFormatInput("1", "1", "2021"));
        }

        [Test]
        public void Test_Month_Format_Input()
        {
            Assert.AreEqual(2, DtChecker.CheckFormatInput("1", "asd", "2021"));
            Assert.AreEqual(0, DtChecker.CheckFormatInput("1", "1", "2021"));
        }

        [Test]
        public void Test_Year_Format_Input()
        {
            Assert.AreEqual(3, DtChecker.CheckFormatInput("1", "1", "asd"));
            Assert.AreEqual(0, DtChecker.CheckFormatInput("1", "1", "2021"));
        }


        [Test]
        public void Test_Day_Range_Input()
        {
            Assert.AreEqual(1, DtChecker.CheckRangeInput(32, 1, 2021));
            Assert.AreEqual(1, DtChecker.CheckRangeInput(0, 1, 2021));
            Assert.AreEqual(0, DtChecker.CheckRangeInput(1, 1, 2021));
        }

        [Test]
        public void Test_Month_Range_Input()
        {
            Assert.AreEqual(2, DtChecker.CheckRangeInput(1, 0, 2021));
            Assert.AreEqual(2, DtChecker.CheckRangeInput(1, 13, 2021));
            Assert.AreEqual(0, DtChecker.CheckRangeInput(1, 1, 2021));
        }

        [Test]
        public void Test_Year_Range_Input()
        {
            Assert.AreEqual(3, DtChecker.CheckRangeInput(1, 1, 999));
            Assert.AreEqual(3, DtChecker.CheckRangeInput(1, 1, 3001));
            Assert.AreEqual(0, DtChecker.CheckRangeInput(1, 1, 2021));
        }
    }
}