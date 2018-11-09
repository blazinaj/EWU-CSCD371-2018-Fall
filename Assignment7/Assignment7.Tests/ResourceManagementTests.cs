using Assignment7;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NotNullableTests
{
    [TestClass]
    public class NotNullableTests
    {
        [TestMethod]
        public void Create_ResourceManagement_Shell_Increments_Count_Success()
        {

            ResourceManagement r = new ResourceManagement();

            r.AddResource();

            Assert.AreEqual(2, r.ResourceCount);

        }

        [TestMethod]
        public void Delete_Resource_Manually_Decrements_Count_Success()
        {
            ResourceManagement r = new ResourceManagement();

            r.RemoveResource();

            Assert.AreEqual(0, r.ResourceCount);
        }

        /*I couldn't figure out how to trick the garbage collector into 
         * Cleaning up my memorystream for me. Failing test
        */
        [TestMethod]
        public void Delete_Resource_Auto_Decrements_Count_Success()
        {
            ResourceManagement r = new ResourceManagement();

            r.AddResource();
            

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Assert.AreEqual(0, r.ResourceCount);
        }
    }
}
