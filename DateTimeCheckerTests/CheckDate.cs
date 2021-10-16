using NUnit.Framework;
using DateTimeChecker;

namespace DateTimeCheckerTests
{
    public class CheckDate
    {
        private DTChecker dtChecker;
        public DTChecker DtChecker { get => dtChecker; set => dtChecker = value; }

        [SetUp]
        public void Setup()
        {
            DtChecker = new DTChecker();
        }

        [Test]
        public void Test_Date_Input()
        {
            Assert.AreEqual(false, DtChecker.IsValidDay(31, 4, 2021));
            Assert.AreEqual(false, DtChecker.IsValidDay(30, 2, 2021));
            Assert.AreEqual(false, DtChecker.IsValidDay(31, 2, 2021));
            Assert.AreEqual(false, DtChecker.IsValidDay(29, 2, 2021));
            Assert.AreEqual(true, DtChecker.IsValidDay(31, 1, 2021));
            Assert.AreEqual(true, DtChecker.IsValidDay(30, 4, 2021));
            Assert.AreEqual(true, DtChecker.IsValidDay(28, 2, 2021));
            Assert.AreEqual(true, DtChecker.IsValidDay(29, 2, 2020));
        }
    }
}