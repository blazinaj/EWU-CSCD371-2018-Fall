using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Assignment4.Tests
{
    [TestClass]
    public class SingleCourseTests
    {
        public SingleCourse testSingleCourse = new SingleCourse("Test Single Course");

        [TestInitialize]
        public void SetupMethod()
        {
            SingleCourse testSingleCourse = new SingleCourse("Test Single Course");
        }

        [TestMethod]
        public void Date_Defaults_To_Today_Success()
        {
            Assert.AreEqual(testSingleCourse.Date, DateTime.Today);
        }
    }
}
