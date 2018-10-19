using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Assignment4.Tests
{
    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void Create_New_Course_Success()
        {
            Course course = new Course("test course");

            Assert.IsInstanceOfType(course, typeof(Course));
        }

    }
}
