using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Assignment8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DispatcherTimer _timer;
        private readonly DispatcherTimer _clock;

        public List<TimeEvent> TimeEvents { get; set; } = new List<TimeEvent>();

        public TimeEvent CurrentEvent { get; set; } = new TimeEvent();


        public MainWindow()
        {
            InitializeComponent();

            _timer = new DispatcherTimer(new TimeSpan(0,0,0,0,50), DispatcherPriority.Normal, TimerOnTick, Dispatcher.CurrentDispatcher);
            _clock = new DispatcherTimer(new TimeSpan(0,0,0,0,50), DispatcherPriority.Normal, ClockOnTick, Dispatcher.CurrentDispatcher);
            _timer.IsEnabled = false;
        }
        private void TimerOnTick(object sender, EventArgs e)
        {
            TimerDisplay.Text = Convert.ToString(DateTime.Now - CurrentEvent.StartTime);
        }


        private void ClockOnTick(object sender, EventArgs e)
        {
            ClockDisplay.Text = DateTime.Now.ToString("H:mm:ss tt");
        }

        private void StartTimer()
        {
            _timer.IsEnabled = true;
            CurrentEvent.StartTimer();
            PauseTimerButton.Visibility = Visibility.Visible;
        }

        private void ResumeTimer()
        {
            _timer.IsEnabled = true;
            CurrentEvent.ResumeTimer();
        }
        
    
        private void StopTimerAndSave()
        {
            if (_timer.IsEnabled)
            {
                _timer.IsEnabled = false;

                CurrentEvent.StopTimerAndSave();

                TimeEvents.Add(CurrentEvent);

                TimeEntryListBox.Items.Add(new ListBoxItem
                {
                    Content = (TimeEvents.Last().ElapsedTime)
                });
                PauseTimerButton.Visibility = Visibility.Hidden;
            }
        }

        private void ResetTimer(object sender, EventArgs e)
        {
            _timer.IsEnabled = false;
            ToggleTimerButton.Content = "START TIMER";
            PauseTimerButton.Visibility = Visibility.Hidden;
            CurrentEvent = new TimeEvent();
            TimerDisplay.Text = (DateTime.Now - DateTime.Now).ToString();

        }

        private void ToggleTimer(object sender, EventArgs e)
        {
            if (!(_timer.IsEnabled))
            {
                StartTimer();
                ToggleTimerButton.Content = "STOP AND SAVE";
            }
            else
            {
                StopTimerAndSave();
                ToggleTimerButton.Content = "START TIMER";
            }
        }

        private void LapTimer(object sender, EventArgs e)
        {
            CurrentEvent.SetLap();
        }

        private void PauseTimerButton_Click(object sender, RoutedEventArgs e)
        {
            if (_timer.IsEnabled)
            {
                _timer.IsEnabled = false;
                CurrentEvent.PauseTimer();
                ToggleTimerButton.Content = "RESUME TIMER";
                PauseTimerButton.Visibility = Visibility.Hidden;
            }
        }
        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TimeEvent item = sender as TimeEvent;
            ElapsedTimeBlock.Content = item.ElapsedTime.ToString();
            StartTimeBlock.Content = item.StartTime.ToString(); 
            StopTimeBlock.Content = item.StopTime.ToString(); 
            MessageBlock.Content = item.Message.ToString(); 
        }
    }
}
