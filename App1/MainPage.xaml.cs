using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ZeroButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ZeroPage));
        }

        private void HalfButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ZeroPage));
        }

        private void FirstButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OnePage));
        }

        private void TwoButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(TwoPage));

        }

        private void ThreeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ThreePage));

        }

        private void FiveButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FivePage));

        }

        private void EightButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EightPage));

        }

        private void ThirteenButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ThirteenPage));

        }

        private void TwenteeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(TwenteePage));

        }

        private void FourtyButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FourtyPage));

        }

        private void HundredButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HundredPage));

        }

        private void InfinityButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfinityPage));

        }

        private void QuestionButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(QuestionPage));

        }

        private void TeaButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(QuestionPage));

        }


    }
}
