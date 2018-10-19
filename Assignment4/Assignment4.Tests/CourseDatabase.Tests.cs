using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Assignment4.Tests
{
    [TestClass]
    public class CourseDatabaseTests
    {
        CourseDatabase testDatabase = new CourseDatabase();

        [TestInitialize]
        public void SetupMethod()
        {
            CourseDatabase testDatabase = new CourseDatabase();
        }

        [TestMethod]
        public void Create_CourseDatabase_Success()
        {
            Assert.IsInstanceOfType(testDatabase, typeof(CourseDatabase));
        }

        [TestMethod]
        public void New_CourseDatabase_Default_Zero_Courses_Success()
        {
            Assert.AreEqual(testDatabase.CourseCount, 0);
        }

        [TestMethod]
        public void Add_New_SingleCourse_Success()
        {
            SingleCourse testCourse = new SingleCourse("Programming Competition");

            testDatabase.AddCourse(testCourse);

            Assert.AreEqual(testDatabase.CourseList[0], testCourse);
        }

        public void Add_New_UniversityCourse_Success()
        {
            UniversityCourse testCourse = new UniversityCourse("CSCD 371");

            testDatabase.AddCourse(testCourse);

            Assert.AreEqual(testDatabase.CourseList, "CSCD 371");
        }
    }
}
