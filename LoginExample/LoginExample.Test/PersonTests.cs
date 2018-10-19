using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace LoginExample.Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void Create_Person_Success()
        {
            Person person = new Person("Inigo", "Montoya", "Password");
            Assert.AreEqual("Inigo", person.FirstName);
            Assert.AreEqual("Inigo", person.LastName);
            Assert.AreEqual("Inigo.Montoya", person.UserName);
        }

        [TestMethod]
        public void Username_ChangeName_Success()
        {
            Person person = new Person("Inigo", "Montoya", "Password");
            person.FirstName = "Frank";
            Assert.AreEqual("Frank", person.FirstName);
            person.LastName = "Nelson";
            Assert.AreEqual("Nelson", person.LastName);
        }
    }
}

/*
 * write a class for course
 * 4 examples that you can implement a property
 * unit test completely
 * -calculated property
 * --property name = name.first name.last
 * ----validation!!!!
 * -------argument exceptions
 * --Store count of number of course objects that get created
 * ---not have any fields that are public (unless it's constant)
 * ----including method that stores # of methods
 * --two constructors
 * ---one constructor calls another constructor
 */