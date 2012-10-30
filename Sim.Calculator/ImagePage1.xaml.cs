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
using System.Windows.Media.Imaging;

namespace Sim.Calculator
{
    public partial class ImagePage1 : PhoneApplicationPage
    {
        public ImagePage1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage myImage = new BitmapImage(new Uri("/Sim.Calculator;component/Images/Background.png", UriKind.Relative));
            image1.Source = myImage;
        }
    }
}