using System;
using System.Collections.Generic;
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

namespace WpfApplication1.pages
{
    /// <summary>
    /// Interaction logic for bar2.xaml
    /// </summary>
    public partial class bar2 : Page
    {
        MediaPlayer bar2music = new MediaPlayer();

        public bar2()
        {
            InitializeComponent();

            bar2music.Open(new Uri("../../sounds/barmusic.mp3", UriKind.Relative));
            bar2music.Volume = 0.05;
            bar2music.Play();
        }

        private void tvscreen_MediaEnded(object sender, RoutedEventArgs e)
        {
            tvscreen.Position = new TimeSpan(0, 0, 1);
            tvscreen.Play();
        }

        private void tvbtn_Click(object sender, RoutedEventArgs e)
        {
            if (tvscreen.Visibility == Visibility.Hidden)
            {
                tvscreen.Visibility = Visibility.Visible;
            }
            else
            {
                tvscreen.Visibility = Visibility.Hidden;
            }
        }

        private void wcbtn_Click(object sender, RoutedEventArgs e)
        {
            bar2music.Stop();
            this.NavigationService.Navigate(new wc());
        }

        private void cashierbtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new barcounter2());
        }

        private void toExercise2btn_Click(object sender, RoutedEventArgs e)
        {
            bar2music.Stop();
            this.NavigationService.Navigate(new exercise2());
        }

        private void toPool2btn_Click(object sender, RoutedEventArgs e)
        {
            bar2music.Stop();
            this.NavigationService.Navigate(new pool2());
        }

        private void toLockers2btn_Click(object sender, RoutedEventArgs e)
        {
            bar2music.Stop();
            this.NavigationService.Navigate(new lockers2());
        }
    }
}
