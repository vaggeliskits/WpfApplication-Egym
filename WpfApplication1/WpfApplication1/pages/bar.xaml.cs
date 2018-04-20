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
    /// Interaction logic for bar.xaml
    /// </summary>
    public partial class bar : Page
    {
        MediaPlayer barmusic = new MediaPlayer();

        public bar()
        {
            InitializeComponent();

            barmusic.Open(new Uri("../../sounds/barmusic.mp3", UriKind.Relative));
            barmusic.Volume = 0.05;
            barmusic.Play();
        }

        //code for continuous gif animation
        private void tvscreen_MediaEnded(object sender, RoutedEventArgs e)
        {
            tvscreen.Position = new TimeSpan(0, 0, 1);
            tvscreen.Play();
        }

        private void cashierbtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new barcounter(tvscreen));
        }

        private void wcbtn_Click(object sender, RoutedEventArgs e)
        {
            barmusic.Stop();
            this.NavigationService.Navigate(new wc());
        }

        private void toExercisebtn_Click(object sender, RoutedEventArgs e)
        {
            barmusic.Stop();
            this.NavigationService.Navigate(new exercise());
        }

        private void toPoolbtn_Click(object sender, RoutedEventArgs e)
        {
            barmusic.Stop();
            this.NavigationService.Navigate(new pool());
        }

        private void toLockersbtn_Click(object sender, RoutedEventArgs e)
        {
            barmusic.Stop();
            this.NavigationService.Navigate(new lockers());
        }
    }
}
