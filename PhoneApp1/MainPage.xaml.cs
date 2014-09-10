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

namespace PhoneApp1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructeur
        public MainPage()
        {
            InitializeComponent();

            foreach (UIElement cc in  TitlePanel.Children)
            {
                (cc as TextBlock).Text = "My Appli"; 
            }
            
            foreach (UIElement cc in  ContentPanel.Children)
            {
                (cc as TextBlock).DoubleTap += zozo; 
            }

            foreach (UIElement cc in ContentPanel.Children)
            {
                (cc as TextBlock).Tap += zero;
            }

            T00.DoubleTap += zozo;

            T00.DoubleTap += zero;
        }

        public void zozo(object sender, System.Windows.Input.GestureEventArgs e)
        {
            (sender as TextBlock).Text = "X";
        }
        
        public void zero(object sender, System.Windows.Input.GestureEventArgs e)
        {
            (sender as TextBlock).Text = "O";
        }
    }
}