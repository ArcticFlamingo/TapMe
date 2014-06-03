using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using TapMe.Resources;
using System.Windows.Threading;

namespace TapMe
{
    public partial class MainPage : PhoneApplicationPage
    {
        Button[] buttons = new Button[12];
        int points = 0;
        int time = 0;
        DispatcherTimer myTime = new DispatcherTimer();

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            //Fill Buttons array
            buttons[0] = Button2;
            buttons[1] = Button3;
            buttons[2] = Button4;
            buttons[3] = Button5;
            buttons[4] = Button6;
            buttons[5] = Button7;
            buttons[6] = Button8;
            buttons[7] = Button9;
            buttons[8] = Button10;
            buttons[9] = Button11;
            buttons[10] = Button12;
            buttons[11] = Button13;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            //Hide all buttons
            Button2.Opacity = 0;
            Button3.Opacity = 0;
            Button4.Opacity = 0;
            Button5.Opacity = 0;
            Button6.Opacity = 0;
            Button7.Opacity = 0;
            Button8.Opacity = 0;
            Button9.Opacity = 0;
            Button10.Opacity = 0;
            Button11.Opacity = 0;
            Button12.Opacity = 0;
            Button13.Opacity = 0;

            //Disable all buttons
            Button2.IsEnabled = false;
            Button3.IsEnabled = false;
            Button4.IsEnabled = false;
            Button5.IsEnabled = false;
            Button6.IsEnabled = false;
            Button7.IsEnabled = false;
            Button8.IsEnabled = false;
            Button9.IsEnabled = false;
            Button10.IsEnabled = false;
            Button11.IsEnabled = false;
            Button12.IsEnabled = false;
            Button13.IsEnabled = false;

            Button1.IsEnabled = false;

            //Reset labels
            GameOver1.Opacity = 0;
            ScoreLabel.Opacity = 0;
            FinalScore.Opacity = 0;
            Score.Opacity = 100;

            //Start Game
            points = 0;
            nextButton();
            time = 0;
           

            myTime.Interval = TimeSpan.FromSeconds(1);
            myTime.Tick += OnTimerTick;
            myTime.Start();

           
        }

        void OnTimerTick(Object sender, EventArgs args)
        {
            //print timer
            if (time == 30)
            {
                endGame();
            }
            else
            time++;
        }

        void endGame()
        {
            //Stop Timer
            myTime.Stop();

            //Hide all buttons
            Button2.Opacity = 0;
            Button3.Opacity = 0;
            Button4.Opacity = 0;
            Button5.Opacity = 0;
            Button6.Opacity = 0;
            Button7.Opacity = 0;
            Button8.Opacity = 0;
            Button9.Opacity = 0;
            Button10.Opacity = 0;
            Button11.Opacity = 0;
            Button12.Opacity = 0;
            Button13.Opacity = 0;

            //Disable all buttons
            Button2.IsEnabled = false;
            Button3.IsEnabled = false;
            Button4.IsEnabled = false;
            Button5.IsEnabled = false;
            Button6.IsEnabled = false;
            Button7.IsEnabled = false;
            Button8.IsEnabled = false;
            Button9.IsEnabled = false;
            Button10.IsEnabled = false;
            Button11.IsEnabled = false;
            Button12.IsEnabled = false;
            Button13.IsEnabled = false;

            //Reset Labels
            Score.Opacity = 0;
            GameOver1.Opacity = 100;
            ScoreLabel.Opacity = 100;
            FinalScore.Text = points.ToString();
            FinalScore.Opacity = 100;

            //Change Button for new game
            Button1.Content = "Play Again";
            Button1.IsEnabled = true;
            Score.Text = "0";
        }

        private int getRandom()
        {
            //Generates a random number
            Random random = new Random();
            int randomNumber = random.Next(0, 12);
            return randomNumber;
        }

        private void nextButton()
        {
            //Randomly selects a button to be pressed
            int rand = getRandom();
            buttons[rand].IsEnabled = true;
            buttons[rand].Opacity = 100;
            Score.Text = points.ToString();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Button2.IsEnabled = false;
            Button2.Opacity = 0;
            points++;
            nextButton();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Button3.IsEnabled = false;
            Button3.Opacity = 0;
            points++;
            nextButton();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Button4.IsEnabled = false;
            Button4.Opacity = 0;
            points++;
            nextButton();
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            Button5.IsEnabled = false;
            Button5.Opacity = 0;
            points++;
            nextButton();
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            Button6.IsEnabled = false;
            Button6.Opacity = 0;
            points++;
            nextButton();
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            Button7.IsEnabled = false;
            Button7.Opacity = 0;
            points++;
            nextButton();
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            Button8.IsEnabled = false;
            Button8.Opacity = 0;
            points++;
            nextButton();
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            Button9.IsEnabled = false;
            Button9.Opacity = 0;
            points++;
            nextButton();
        }

        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            Button10.IsEnabled = false;
            Button10.Opacity = 0;
            points++;
            nextButton();
        }

        private void Button11_Click(object sender, RoutedEventArgs e)
        {
            Button11.IsEnabled = false;
            Button11.Opacity = 0;
            points++;
            nextButton();
        }

        private void Button12_Click(object sender, RoutedEventArgs e)
        {
            Button12.IsEnabled = false;
            Button12.Opacity = 0;
            points++;
            nextButton();
        }

        private void Button13_Click(object sender, RoutedEventArgs e)
        {
            Button13.IsEnabled = false;
            Button13.Opacity = 0;
            points++;
            nextButton();
        }
    }
}