using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoginExample
{
    [TestClass]
    public class ApplicationTests
    {
        [TestMethod]
        public void Login_UserNameWithValidPassword_ReturnTrue()
        {
            Assert.IsTrue (
                Application.Login("Inigo Montoya", "password")
            );
        }

        [TestMethod]
        public void Login_UserNameWithInvalidPassword_ReturnTrue()
        {
            Assert.IsTrue(
                Application.Login("Inigo Montoya", "badpassword")
            );
        }

        [TestMethod]
        public void Login_UserNamePrincessButtercupInvalidPassword_ReturnTrue()
        {
            Assert.IsTrue(
                Application.Login("Princess.Buttercup", "AnybodyWantAPeanut")
            );
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void Login_UserNameIsNull_ThrowException()
        {
            Application.Login(null, "password");
        }
    }
}
