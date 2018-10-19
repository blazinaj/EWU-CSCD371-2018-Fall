using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Assignment4.Tests
{
    [TestClass]
    public class UniversityCourseTests
    {
        public UniversityCourse testUniversityCourse = new UniversityCourse("Test University Course");

        [TestInitialize]
        public void SetupMethod()
        {
            UniversityCourse testUniversityCourse = new UniversityCourse("Test University Course");
        }

        [TestMethod]
        public void Schedule_Defaults_To_Daily_Success()
        {
            Assert.AreEqual(testUniversityCourse.CourseSchedule, "daily");
        }
        
    }
}
