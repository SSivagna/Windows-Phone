using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Windows.Threading;

namespace PhoneApp2
{
    public partial class MainPage : PhoneApplicationPage
    {
        private int count;

        DispatcherTimer dt = new DispatcherTimer();
     
        // Constructeur
        public MainPage()
        {
            count = 0;
            InitializeComponent();

           // dt.Tick += onTimerTick;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TBL1.Text = "Hello";
            count++;
            TBL1.Text = count.ToString();

            DispatcherTimer newTimer = new DispatcherTimer();
            newTimer.Interval = TimeSpan.FromSeconds(1);
          //  newTimer.Tick += onTimerTick;
            newTimer.Start();
                          
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_initialize(object sender, RoutedEventArgs e)
        {
            count = 0;
            TB0.Text = "";
            TBL1.Text = count.ToString();
        }

        public void onTimerTick(object sender, System.Windows.Input.GestureEventArgs e)
        {
            (sender as TextBlock).Text += count.ToString();
        }
    }
}