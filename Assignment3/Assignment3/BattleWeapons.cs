using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public static class BattleWeapons
    {
        public static bool BattleResult<Weapon1, Weapon2>(this Tuple<Weapon1, Weapon2> weapons, Weapon1 weapon1Type, Weapon2 weapon2Type)
        {
            return weapons.Item1.Equals(weapon1Type) && weapons.Item2.Equals(weapon2Type);
        }
    }
}
