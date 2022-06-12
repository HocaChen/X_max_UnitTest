using NUnit.Framework;
using System;
using Xmax;

namespace XmaxTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestXmax_giveDummyData_getExpectedRet()
        {
            var a = new FakeLogic();
            Assert.AreEqual("Today is not Xmax", a.TodayIsXmax());
        }

        [Test]
        public void TestXmax_giveIsXmaxDate_getExpectedRet()
        {
            var a = new FakeLogic();
            a.SetDummyDate(new DateTime(2021, 12, 25));
            Assert.AreEqual("Today is not Xmax", a.TodayIsXmax());
        }

    }

    public class FakeLogic : Logic
    {
        private DateTime _date;

        public void SetDummyDate(DateTime date)
        {
            _date = date;
        }
        protected override DateTime GetDate()
        {
            return DateTime.Today;
        }
    }
}