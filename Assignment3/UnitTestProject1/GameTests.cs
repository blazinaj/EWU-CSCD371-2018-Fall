using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment3.Test
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void Computer_VS_Computer_Has_A_Winner()
        {

            Game testGame = new Game("computer", "computer");

            Assert.AreNotEqual(testGame.winner, "none");
        }

    }
}
