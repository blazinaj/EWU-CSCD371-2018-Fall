using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment3.Test
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void Create_Human_Player_Success()
        {
            Player testPlayer = new Player("human");
            Assert.IsFalse(testPlayer.computerController);
        }

        [TestMethod]
        public void Create_Computer_Player_Success()
        {
            Player testPlayer = new Player("computer");
            Assert.IsTrue(testPlayer.computerController);
        }

        [TestMethod]
        public void Player_Starts_With_100_Life_Success()
        {
            Player testPlayer = new Player("human");
            Assert.AreEqual(testPlayer.lifePoints, 100);
        }

        [TestMethod]
        public void Computer_Can_Draw_Weapon_Rock()
        {
            Player testPlayer = new Player("computer");
            bool isRock = false;
            int timeOut = 60;
            while (!isRock && timeOut > 0)
            {
                string testWeapon = testPlayer.DrawWeapon();
                if (testWeapon.Equals("rock"))
                    isRock = true;
                timeOut--;
            }
            Assert.IsTrue(isRock);
        }

        [TestMethod]
        public void Computer_Can_Draw_Weapon_Paper()
        {
            Player testPlayer = new Player("computer");
            bool isRock = false;
            int timeOut = 60;
            while (!isRock && timeOut > 0)
            {
                string testWeapon = testPlayer.DrawWeapon();
                if (testWeapon.Equals("paper"))
                    isRock = true;
                timeOut--;
            }
            Assert.IsTrue(isRock);
        }

        [TestMethod]
        public void Computer_Can_Draw_Weapon_Scissors()
        {
            Player testPlayer = new Player("computer");
            bool isRock = false;
            int timeOut = 60;
            while (!isRock && timeOut > 0)
            {
                string testWeapon = testPlayer.DrawWeapon();
                if (testWeapon.Equals("scissors"))
                    isRock = true;
                timeOut--;
            }
            Assert.IsTrue(isRock);
        }
    }
}
