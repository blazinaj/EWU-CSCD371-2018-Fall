using System;

namespace Assignment6t
{
    public class EnumsAndStructs
    {
        [Flags]
        public enum DaysOfWeek
        {
            Sunday = 0x00,
            Monday = 0x02,
            Tuesday = 0x04,
            Wednesday = 0x08,
            Thursday = 0x16,
            Friday = 0x32,
            Saturday = 0x64
        }

        public enum Quarters
        {
            Fall = 1,
            Winter = 2,
            Spring = 3,
            Summer = 4
        }

        public struct StartTime
        {
            public int Time{ get; }
            public StartTime(int time)
            {
                Time = time;
            }
        }

        public struct Schedule
        {
            public DaysOfWeek Days { get; }
            public Quarters Quarter { get; }
            public StartTime Start { get; }
            public TimeSpan Duration { get; }
            public Schedule(DaysOfWeek days, Quarters quarter, StartTime start, TimeSpan duration)
            {
                Days = days;
                Quarter = quarter;
                Start = start;
                Duration = duration;
            }
        }
    }

    /*
        Part 2
    */


    public class MyClass
    {
        public MyClass(int a, int b)
        {
            PropertyOne = a;
            PropertyTwo = b;
        }
        public int PropertyOne { get; set; }
        public int PropertyTwo { get; set; }
    }

    public interface ISimpleInterface
    {
        int PropertyOne { get; set; }
        int PropertyTwo { get; set; }
    }

    public struct MyStruct : ISimpleInterface
    {
        public int PropertyOne { get; set; }
        public int PropertyTwo { get; set; }
    }
}
