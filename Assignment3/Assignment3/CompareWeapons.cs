using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public static class CompareWeapons
    {
        public static bool Compare<T1, T2>(this Tuple<T1, T2> value, T1 v1, T2 v2)
        {
            return value.Item1.Equals(v1) && value.Item2.Equals(v2);
        }
    }
}
