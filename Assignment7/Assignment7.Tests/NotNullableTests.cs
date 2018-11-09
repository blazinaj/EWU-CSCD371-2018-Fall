using Assignment7s;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment7Tests
{
    [TestClass]
    public class NotNullableTests
    {
        /*
         * Commented out to compile. Depending on how the NotNullable is implemented, 
         * either test may cause a compile-time error.
         */
        [TestMethod]
        public void NotNullable_As_RefType_Can_Not_Be_Null()
        {
            //NotNullable<string> notNullable = new NotNullable<string>();

            //notNullable.Value = null;

            //Assert.IsNotNull(notNullable.Value);
        }

        [TestMethod]
        public void NotNullable_As_ValueType_Can_Not_Be_Null()
        {
            //NotNullable<int> notNullable = new NotNullable<int>();

            //notNullable.Value = null;

            //Assert.IsNotNull(notNullable.Value);
        }

        [TestMethod]
        public void NotNullable_Pass_In_Class_Should_Be_Null()
        {
            NotNullable<TestClass> notNullable = new NotNullable<TestClass>();

            Assert.AreEqual(null, notNullable.Value);
        }

        [TestMethod]
        public void NotNullable_Pass_In_Struct_Shouldnt_Be_Null()
        {
            NotNullable<TestStruct> notNullable = new NotNullable<TestStruct>();

            Assert.AreNotEqual(null, notNullable.Value);
        }

        [TestMethod]
        public void NotNullable_Sets_Value_Correctly()
        {
            NotNullable<TestStruct> notNullable = new NotNullable<TestStruct>();


        }
        public class TestClass
        {
            // test
        }

        public struct TestStruct
        {
            // test
        }
    }
}

