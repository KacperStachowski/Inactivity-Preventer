using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
using System.Windows.Forms;

namespace MouseMove
{
    public partial class MainWindow : Window
    {
        private int interval;
        DispatcherTimer timer;

        [DllImport("User32.dll")]
        private static extern bool SetCursorPos(int X, int Y);

        public MainWindow()
        {
            InitializeComponent();

            StopButton.IsEnabled = false;
            IsKeyboardIncluded.IsChecked = true;
        }


        public Point GetMousePositionWindowsForms()
        {
            System.Drawing.Point point = System.Windows.Forms.Control.MousePosition;
            return new Point(point.X, point.Y);
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            SetIsEnabled(false);

            interval = Convert.ToInt32(IntervalTextBox.Text);
            InitializeProgressBar();

            StopButton.IsEnabled = true;
            StartButton.IsEnabled = false;

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void InitializeProgressBar(int start = 0)
        {
            TimeProgressBar.Minimum = 0;
            TimeProgressBar.Maximum = interval;
            TimeProgressBar.Value = start;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var secondsPassed = UpdateTimerLabels();
            var mod = secondsPassed % interval;

            if (mod == 0)
            {
                MoveMouse();
            }

            TimeProgressBar.Value = mod;
        }

        private int UpdateTimerLabels()
        {
            int secondsPassed;
            var secondsInt = int.TryParse(TimerLabelSeconds.Text, out secondsPassed);

            int minutesPassed;
            var minutesInt = int.TryParse(TimerLabelMinutes.Text, out minutesPassed);

            int hoursPassed;
            var hoursInt = int.TryParse(TimerLabelHours.Text, out hoursPassed);

            if (secondsInt && minutesInt && hoursInt)
            {
                if (secondsPassed % 60 == 0 && secondsPassed > 0)
                {
                    TimerLabelSeconds.Text = "00";
                    minutesPassed = minutesPassed + 1;
                    secondsPassed = 0;

                    if (minutesPassed % 60 == 0 && minutesPassed > 0)
                    {
                        TimerLabelMinutes.Text = "00";
                        hoursPassed = hoursPassed + 1;
                        minutesPassed = 0;
                    }
                }

                secondsPassed = secondsPassed + 1;

                TimerLabelSeconds.Text = secondsPassed < 10 ? "0" + secondsPassed : secondsPassed.ToString();
                TimerLabelMinutes.Text = minutesPassed < 10 ? "0" + minutesPassed : minutesPassed.ToString();
                TimerLabelHours.Text = hoursPassed < 10 ? "0" + hoursPassed : hoursPassed.ToString();
            }

            return secondsPassed;
        }


        private void MoveMouse()
        {
            var random = new Random();
            var numberOfMoves = random.Next(10, 20);
            var currentMousePosition = GetMousePositionWindowsForms();

            for (int i = 1; i <= numberOfMoves; i++)
            {
                SetCursorPos((int)currentMousePosition.X + random.Next(200), (int)currentMousePosition.Y);
                System.Threading.Thread.Sleep(50);
                SetCursorPos((int)currentMousePosition.X + random.Next(200), (int)currentMousePosition.Y - random.Next(200));
                System.Threading.Thread.Sleep(50);
                SetCursorPos((int)currentMousePosition.X, (int)currentMousePosition.Y - random.Next(200));
                System.Threading.Thread.Sleep(50);

                System.Windows.Forms.SendKeys.SendWait("Q");
            }

            SetCursorPos((int)currentMousePosition.X, (int)currentMousePosition.Y);
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            SetIsEnabled(true);
            StartButton.IsEnabled = true;
            StopButton.IsEnabled = false;

            timer.Stop();
            TimerLabelSeconds.Text = "00";
            TimerLabelMinutes.Text = "00";
            TimerLabelHours.Text = "00";
            TimeProgressBar.Value = 0;
        }

        private void NumericTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var control = sender as System.Windows.Controls.TextBox;
            if (control != null)
            {
                int result;
                var isInt = int.TryParse(control.Text, out result);

                if (!isInt || result < 0)
                {
                    e.Handled = true;
                }
            }
        }

        private void SetIsEnabled(bool state)
        {
            KeyboardGroupbox.IsEnabled = state;
            OptionsGroupBox.IsEnabled = state;
        }

        #region -- UI validation --

        private void IsKeyboardIncluded_Checked(object sender, RoutedEventArgs e)
        {
            KeyboardInputTextBox.IsEnabled = true;
        }

        private void IsKeyboardIncluded_Unchecked(object sender, RoutedEventArgs e)
        {
            KeyboardInputTextBox.IsEnabled = false;
        }

        private void NumberOfActionsMinValueTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            var control = sender as System.Windows.Controls.TextBox;
            if (control != null)
            {
                int result;
                var isInt = int.TryParse(control.Text, out result);

                if (!isInt || result < 10)
                {
                    control.Text = "10";
                    e.Handled = true;
                }

                var maxValue = Convert.ToInt32(NumberOfActionsMaxValueTextBox.Text);

                if (result >= maxValue)
                {
                    control.Text = (maxValue - 1).ToString();
                    e.Handled = true;
                }

                if (result > 98)
                {
                    control.Text = "98";
                    e.Handled = true;
                }
            }
        }

        private void NumberOfActionsMaxValueTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            var control = sender as System.Windows.Controls.TextBox;
            if (control != null)
            {
                int result;
                var isInt = int.TryParse(control.Text, out result);

                var minValue = Convert.ToInt32(NumberOfActionsMinValueTextBox.Text);

                if (!isInt || result < minValue)
                {
                    control.Text = (minValue + 1).ToString();
                    e.Handled = true;
                }

                if (result > 99)
                {
                    control.Text = "99";
                    e.Handled = true;
                }
            }
        }

        private void IntervalTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            var control = sender as System.Windows.Controls.TextBox;
            if (control != null)
            {
                int result;
                var isInt = int.TryParse(control.Text, out result);

                if (!isInt || result < 5)
                {
                    control.Text = "5";
                    e.Handled = true;
                }

                if(result > 300)
                {
                    control.Text = "300";
                    e.Handled = true;
                }
            }
        }

        #endregion
    }
}
