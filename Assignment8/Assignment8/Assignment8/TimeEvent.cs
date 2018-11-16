using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Assignment8
{
    /*
     * NOTE: I was working on implementing proper pause/lap timer features.
     * The Pause button is malfunctioning and the lap timer button is turned off.
     * 
     * This GUI stuff is really cool and very expansive, I wish we had more than 1 week on a project like this
     * for important concepts like Delegates, Events, and Handlers to really sink in.
     * 
     * I didn't have the time in one week to properly dig into the specifics of XAML and WPF, 
     * along with the general concepts of Delegates, Events, Timers, and Threading. All of these
     * I assume are the building blocks of UI design, and I wish we had gotten to spend more time
     * covering these core topics.
     * 
     * Cheers to Expectations, and things.
     * 
     * P.S. Very limited testing... spent my week trying to learn how the other stuff works!!
     * 
     */
    public class TimeEvent
    {
        public bool TimerOn { get; set; }
        public TimeSpan ElapsedTime { get; set; } = new TimeSpan(0);

        public DateTime StartTime { get; set; }

        private DateTime PauseTime { get; set; }

        private DateTime ResumeTime { get; set; }

        private bool IsPaused { get; set; } = false;

        public List<TimeSpan> LapTimes { get; set; }

        public DateTime StopTime { get; set; }

        public string Message { get; set; }

        private static DateTime Now()
        {
            return DateTime.Now;
        }

        public void SetLap()
        {
            /*if (TimerOn)
                LapTimes.Add(ElapsedTime);*/
        }

        public void StartTimer()
        {
            if (!(TimerOn) && !(IsPaused))
            {
                TimerOn = true;
                StartTime = Now();
            }
            else if (IsPaused)
            {
                TimerOn = true;
                IsPaused = false;
            }
        }

        public void ResumeTimer()
        {
            if (!(TimerOn))
            {
                TimerOn = true;
                ResumeTime = Now();
            }
        }
       

        public void PauseTimer()
        {
            if (TimerOn)
            {
                PauseTime = Now();
                ElapsedTime = PauseTime - StartTime;
                TimerOn = false;
            }
        }

        public void StopTimerAndSave()
        {
            if (TimerOn)
            {
                StopTime = Now();
                ElapsedTime = StopTime - StartTime;
                TimerOn = false;
            }
        }

        public void AddMessage(string message)
        {
            Message = message;
        }
    }
}
