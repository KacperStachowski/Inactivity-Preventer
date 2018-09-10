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

            SetIsEnabled(true);
            IsKeyboardIncluded.IsChecked = true;

            ShowAboutPanel(false);
        }

        #region -- Initialization methods --

        private void InitializeTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
        }

        private void InitializeProgressBar(int start = 0)
        {
            TimeProgressBar.Minimum = 0;
            TimeProgressBar.Maximum = interval;
            TimeProgressBar.Value = start;
        }

        #endregion

        #region -- UI validation --

        private void IsKeyboardIncluded_Checked(object sender, RoutedEventArgs e)
        {
            KeyboardOptionsGrid.IsEnabled = true;
        }

        private void IsKeyboardIncluded_Unchecked(object sender, RoutedEventArgs e)
        {
            KeyboardOptionsGrid.IsEnabled = false;
        }

        private void NumberOfActionsMinValueTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            var control = sender as System.Windows.Controls.TextBox;
            if (control != null)
            {
                int result;
                var isInt = int.TryParse(control.Text, out result);

                if (!isInt || result < 1)
                {
                    control.Text = "5";
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

                if (result > 300)
                {
                    control.Text = "300";
                    e.Handled = true;
                }
            }
        }

        private void AboutLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (AboutGrid.Visibility == Visibility.Visible)
            {
                ShowAboutPanel(false);
            }

            else
            {
                ShowAboutPanel(true);
            }
        }

        #endregion

        #region -- Value setting methods --

        private void ResetTimerValues()
        {
            TimerLabelSeconds.Text = "00";
            TimerLabelMinutes.Text = "00";
            TimerLabelHours.Text = "00";
            TimeProgressBar.Value = 0;
        }

        private void SetIsEnabled(bool state)
        {
            KeyboardGroupbox.IsEnabled = state;
            OptionsGroupBox.IsEnabled = state;

            StopButton.IsEnabled = !state;
            StartButton.IsEnabled = state;
        }

        private int UpdateTimerLabels()
        {
            int secondsPassed = Convert.ToInt32(TimerLabelSeconds.Text);
            int minutesPassed = Convert.ToInt32(TimerLabelMinutes.Text);
            int hoursPassed = Convert.ToInt32(TimerLabelHours.Text);

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

            return secondsPassed;
        }

        private void ShowAboutPanel(bool state)
        {
            if (state == true)
            {
                AboutGrid.Visibility = Visibility.Visible;
            }
            else
            {
                AboutGrid.Visibility = Visibility.Hidden;
            }
        }

        #endregion


        public Point GetMousePosition()
        {
            System.Drawing.Point point = System.Windows.Forms.Control.MousePosition;
            return new Point(point.X, point.Y);
        }



        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            SetIsEnabled(false);

            interval = Convert.ToInt32(IntervalTextBox.Text);

            InitializeProgressBar();
            InitializeTimer();

            timer.Start();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            SetIsEnabled(true);

            timer.Stop();

            ResetTimerValues();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var secondsPassed = UpdateTimerLabels();
            var mod = secondsPassed % interval;

            //ensures that progress bar will reach max value when mouse moves
            if (mod == 0 && secondsPassed > 0)
            {
                TimeProgressBar.Value = interval;
            }
            else
            {
                TimeProgressBar.Value = mod;
            }

            if (mod == 0)
            {
                MoveMouse();
            }
        }

        private void MoveMouse()
        {
            var random = new Random();
            var numberOfMoves = random.Next(Convert.ToInt32(NumberOfActionsMinValueTextBox.Text), Convert.ToInt32(NumberOfActionsMaxValueTextBox.Text));
            var currentMousePosition = GetMousePosition();

            for (int i = 1; i <= numberOfMoves; i++)
            {
                SetCursorPos((int)currentMousePosition.X + random.Next(200), (int)currentMousePosition.Y);
                System.Threading.Thread.Sleep(50);
                SetCursorPos((int)currentMousePosition.X + random.Next(200), (int)currentMousePosition.Y - random.Next(200));
                System.Threading.Thread.Sleep(50);
                SetCursorPos((int)currentMousePosition.X, (int)currentMousePosition.Y - random.Next(200));
                System.Threading.Thread.Sleep(50);

                if ((bool)IsKeyboardIncluded.IsChecked)
                {
                    SendKeys.SendWait(KeyboardInputTextBox.Text);
                }
            }

            SetCursorPos((int)currentMousePosition.X, (int)currentMousePosition.Y);
        }

    }
}
