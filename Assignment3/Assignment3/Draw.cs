using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Draw
    {
        public string weapon;
        public Draw()
        {
            Random randomWeapon = new Random();

            int weaponType = randomWeapon.Next(1, 4);

            switch (weaponType)
            {
                case 1:
                    weapon = "rock";
                    break;
                case 2:
                    weapon = "paper";
                    break;
                case 3:
                    weapon = "scissors";
                    break;
                default:
                    weapon = "none";
                    break;
            }

        }

        public string SelectWeapon()
        {
            Console.Write("3..2..1.. Draw!: ");

            string drawnWeapon = Console.ReadLine();

            switch (drawnWeapon)
            {
                case "rock":
                    return "rock";
                case "paper":
                    return "paper";
                case "scissors":
                    return "scissors";
                default:
                    return SelectWeapon();
            }
        }

        override
        public string ToString()
        {
            return weapon;
        }
    }
}
