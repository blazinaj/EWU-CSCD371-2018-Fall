using Assignment6t;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;
using static Assignment6t.EnumsAndStructs;

namespace Assignment6tTests
{
    [TestClass]
    public class EnumsAndStructsTests
    {
        [TestMethod]
        public void DaysOfWeek_Flags_Parse_Correctly()
        {
            string enumString = (DaysOfWeek.Monday | DaysOfWeek.Tuesday).ToString();

            Enum.TryParse(enumString, out DaysOfWeek days);

            Assert.AreEqual("Monday, Tuesday", days.ToString());

        }

        [TestMethod]
        public void Quarters_Parse_Correctly()
        {
            string enumString = (Quarters.Fall).ToString();

            Enum.TryParse(enumString, out Quarters quarter);

            Assert.AreEqual("Fall", quarter.ToString());
        }

        [TestMethod]
        public void Structs_Are_Readonly()
        {
            Schedule schedule = new Schedule(DaysOfWeek.Monday, Quarters.Fall, new StartTime(10), new TimeSpan());
            //schedule.Days = Tuesday;
            //Compiler Error "cannot be assigned to -- it's readonly"
            Assert.AreNotEqual(schedule.Days, DaysOfWeek.Tuesday);
        }

        [TestMethod]
        public void Structs_Are_Smaller_Than_16_Bytes()
        {
            Schedule schedule = new Schedule(DaysOfWeek.Monday, Quarters.Fall, new StartTime(10), new TimeSpan());
            int size = Marshal.SizeOf(typeof(Schedule));
            Assert.AreEqual(16, size);
            //Smallest I can get is 24 bytes
        }

        //Helper Methods for Testing//
        void MutateInMethod(ISimpleInterface inputStruct)
        {
            inputStruct.PropertyOne = inputStruct.PropertyTwo;
        }
        void MutateInMethodByRef(ref MyStruct inputStruct)
        {
            inputStruct.PropertyOne = inputStruct.PropertyTwo;
        }
        void MutateInMethodByValue(MyStruct inputStruct)
        {
            inputStruct.PropertyOne = inputStruct.PropertyTwo;
        }
        void MutateInMethod(MyClass inputClass)
        {
            inputClass.PropertyOne = inputClass.PropertyTwo;
        }
        void MutateInMethodInstance(MyClass inputClass)
        {
            MyClass secondClass = inputClass;
            secondClass.PropertyOne = secondClass.PropertyTwo;
        }

        [TestMethod]
        public void Cast_Struct_To_Interface_Pass_To_Method_Change_Value_Success()
        {
            var myStruct = new MyStruct { PropertyOne = 1, PropertyTwo = 2 };
            var myISimpleInterface = myStruct as ISimpleInterface;

            MutateInMethod(myISimpleInterface);

            Assert.AreEqual(myISimpleInterface.PropertyTwo, myISimpleInterface.PropertyOne);
        }

        [TestMethod]
        public void Pass_Struct_To_Method_Change_Value_Struct_Is_Changed()
        {
            var myStruct = new MyStruct { PropertyOne = 1, PropertyTwo = 2 };

            MutateInMethodByRef(ref myStruct);

            Assert.AreEqual(myStruct.PropertyTwo, myStruct.PropertyOne);
        }

        [TestMethod]
        public void Pass_Struct_To_Method_Change_Value_Struct_Not_Changed_()
        {
            var myStruct = new MyStruct { PropertyOne = 1, PropertyTwo = 2 };

            MutateInMethodByValue(myStruct);

            Assert.AreNotEqual(myStruct.PropertyTwo, myStruct.PropertyOne);
        }

  
        [TestMethod]
        public void Pass_Class_To_Method_Change_Value_Class_Is_Changed()
        {
            var myClass = new MyClass(1, 2);

            MutateInMethod(myClass);

            Assert.AreEqual(myClass.PropertyTwo, myClass.PropertyOne);
        }

        [TestMethod]
        public void Pass_Class_New_Instance_To_Method_Change_Value_Class_Is_Changed()
        {
            var myClass = new MyClass(1, 2);

            MutateInMethodInstance(myClass);

            Assert.AreEqual(myClass.PropertyTwo, myClass.PropertyOne);
        }
    }
}
