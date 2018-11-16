using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Assignment8.Tests
{
    [TestClass]
    public class TimeEventTests
    {


        [TestMethod]
        public void CreateNewTimeEvent_Success()
        {
            TimeEvent testEvent = new TimeEvent();
            Assert.IsInstanceOfType(testEvent, typeof(TimeEvent));
        }

        [TestMethod]
        public void TimeEventElapsedTime_5seconds()
        {
            TimeEvent testEvent = new TimeEvent();
            testEvent.StartTimer();
            System.Threading.Thread.Sleep(5000);
            testEvent.StopTimerAndSave();

            Assert.AreEqual(5, testEvent.ElapsedTime.Seconds);
        }

        [TestMethod]
        public void TimeEventPaused_5seconds()
        {
            TimeEvent testEvent = new TimeEvent();
            testEvent.StartTimer();
            System.Threading.Thread.Sleep(1000);
            testEvent.PauseTimer();
            System.Threading.Thread.Sleep(4321);
            testEvent.ResumeTimer();
            System.Threading.Thread.Sleep(1000);
            testEvent.StopTimerAndSave();

            Assert.AreEqual(2, testEvent.ElapsedTime.Seconds);
        }
        
    }
}
