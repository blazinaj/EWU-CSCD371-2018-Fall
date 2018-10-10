using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Player
    {
        public int lifePoints;
        public bool computerController;

        public Player(string playerType)
        {
            lifePoints = 100;

            switch (playerType)
            {
                case "computer":
                    computerController = true;
                    break;
                case "human":
                    computerController = false;
                    break;
                default:
                    computerController = false;
                    break;
            }
        }

        public string DrawWeapon()
        {
            switch (computerController)
            {
                case true:
                    return new Draw().ToString();
                case false:
                    return new Draw().SelectWeapon();
                default:
                    return "weapon_error";
            }
        }
    }
}
