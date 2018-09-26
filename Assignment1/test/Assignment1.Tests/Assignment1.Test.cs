using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment1.Tests
{
    [TestClass]
    public class InputOutputTest
    {
        [TestMethod]
        public void TestInputOutput()
        {
            string expectedOutput = $">>Hello, what is your name?\n" +
                "<<{expectedInput}\n" +
                ">>Hello {expectedInput}!\n";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOutput, global::Assignment1.Assignment1.Main);
        }
    }
}
