using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Assignment4.Tests
{
    [TestClass]
    public class UniversityCourseTests
    {
        //[ClassInitialize]//runs at the beginning of the test class.
        //1. write the test
        //2. production code that completes the test
        //3. Refactor

        [TestInitialize]
        public void SetupMethod()
        {
            //GUIDELINE: always clean up in the start test, not the end
            Application.RegisteredPeopleIds.Clear();
            //good place to setup instances
            //private Person Person { get; set; }
            //makes a new person for every test
        }

        /*[TestCleanup]
        public void CleanupTest()
        {
            //GUIDELINE: don't have to clean at the end unless large files
            Application.RegisteredPeopleIds.Clear();
        }
        */

        [TestMethod]
        [DataRow(".Montoya")]
        [DataRow(".")]
        [DataRow("")]
        //TO TEST MULTIPLE THINGS WITH ONE TEST
        public void Create_University_Course()
        {

        }

        [TestMethod]
        public void Test_Register_Adds_Multiple_People_Success()
        {
            UniversityCourse course1 = new UniversityCourse();
            UniversityCourse course2 = new UniversityCourse();

            int count1 = Application.Register(course1);
            int count2 = Application.Register(course2);


            Assert.AreEqual(1, count1);
            Assert.AreEqual(2, count2);


            //we want ability to pass different types of objects
            // and save if an id exists
            // and throw an error if the ids don't exist
        }

        [TestMethod]
        public void Test_Register_With_UniversityCourse()
        {
            UniversityCourse course = new UniversityCourse();
            Application.RegisteredPeopleIds.Clear();
            int count = Application.Register(course);

            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void Register_With_UniversityCourse()
        {
            var course = new UniversityCourse
            {
                Id = '42'
            };

            int count = Application.Register(course);

            Assert.AreEqual(1, count);
        }

        [TestMethod]
        [Ignore("Not implemented yet")]
        [ExpectedException(typeof(ArgumentException))]
        public void Register_With_Object_Does_Not_Increment()
        {
            var course = new UniversityCourse
            {
                Id = '42'
            };

            int count = Application.Register(course);

            Assert.AreEqual(1, count);
        }
    }
}
