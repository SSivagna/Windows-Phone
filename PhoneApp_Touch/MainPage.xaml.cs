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

namespace PhoneApp_Touch
{
    public partial class MainPage : PhoneApplicationPage
    {
        int nbMoves;

        // Constructeur
        public MainPage()
        {
            InitializeComponent();
            Touch.FrameReported += OnTouchFrameReported;
        }

        void OnTouchFrameReported(object sender, TouchFrameEventArgs args)
        {
            TouchPoint PritTouch = args.GetPrimaryTouchPoint(null);

            if (PritTouch != null)
            {
                nbMoves = 0;
            }

            if (PritTouch.Action == TouchAction.Move)
            {
                nbMoves++;
            }

            textblock1.Text = String.Format("{0}-{1}", nbMoves.ToString(), PritTouch.Position.ToString());
            ContentPanel.Background = new SolidColorBrush(Color.FromArgb(255, (byte)nbMoves, (byte)PritTouch.Position.X, (byte)PritTouch.Position.Y));

        }
    }
}