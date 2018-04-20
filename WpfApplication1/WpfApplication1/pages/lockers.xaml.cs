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
using System.Windows.Threading;

namespace WpfApplication1.pages
{
    /// <summary>
    /// Interaction logic for lockers.xaml
    /// </summary>

    public partial class lockers : Page
    {
        DispatcherTimer shower1timer = new DispatcherTimer();
        DispatcherTimer shower2timer = new DispatcherTimer();
        DispatcherTimer shower3timer = new DispatcherTimer();

        MediaPlayer showersound = new MediaPlayer();
        MediaPlayer fansound = new MediaPlayer();
        MediaPlayer heatersound = new MediaPlayer();

        public lockers()
        {
            InitializeComponent();
            shower1timer.Tick += new EventHandler(shower1timer_tick);
            shower1timer.Interval = new TimeSpan(0, 0, 0, 1);
            shower2timer.Tick += new EventHandler(shower2timer_tick);
            shower2timer.Interval = new TimeSpan(0, 0, 0, 1);
            shower3timer.Tick += new EventHandler(shower3timer_tick);
            shower3timer.Interval = new TimeSpan(0, 0, 0, 1);
        }

        private void fan_MediaEnded(object sender, RoutedEventArgs e)
        {
            fan.Position = new TimeSpan(0, 0, 1);
            fan.Play();
        }

        public void shower1timer_tick(object sender, EventArgs e)
        {
            shower1pb.Value++;

            if (shower1pb.Value == shower1pb.Maximum)
            {
                MessageBox.Show("Ξεβρώμισα...");
                shower1pb.Visibility = Visibility.Hidden;
                curtain1.Visibility = Visibility.Hidden;
                shower1timer.Stop();
            }
        }

        public void shower2timer_tick(object sender, EventArgs e)
        {
            shower2pb.Value++;

            if (shower2pb.Value == shower2pb.Maximum)
            {
                MessageBox.Show("Ξεβρώμισα...");
                shower2pb.Visibility = Visibility.Hidden;
                curtain2.Visibility = Visibility.Hidden;
                shower2timer.Stop();
            }
        }

        public void shower3timer_tick(object sender, EventArgs e)
        {
            shower3pb.Value++;

            if (shower3pb.Value == shower3pb.Maximum)
            {
                MessageBox.Show("Ξεβρώμισα...");
                shower3pb.Visibility = Visibility.Hidden;
                curtain3.Visibility = Visibility.Hidden;
                shower3timer.Stop();
            }
        }

        private void shower1btn_Click(object sender, RoutedEventArgs e)
        {
            showersound.Open(new Uri("../../sounds/shower.wav", UriKind.Relative));
            showersound.Play();

            shower1pb.Value = 0;
            curtain1.Visibility = Visibility.Visible;
            shower1pb.Visibility = Visibility.Visible;
            shower1timer.Start();
        }

        private void shower2btn_Click(object sender, RoutedEventArgs e)
        {
            showersound.Open(new Uri("../../sounds/shower.wav", UriKind.Relative));
            showersound.Play();

            shower2pb.Value = 0;
            curtain2.Visibility = Visibility.Visible;
            shower2pb.Visibility = Visibility.Visible;
            shower2timer.Start();
        }

        private void shower3btn_Click(object sender, RoutedEventArgs e)
        {
            showersound.Open(new Uri("../../sounds/shower.wav", UriKind.Relative));
            showersound.Play();

            shower3pb.Value = 0;
            curtain3.Visibility = Visibility.Visible;
            shower3pb.Visibility = Visibility.Visible;
            shower3timer.Start();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (rd3btn1.IsChecked == true)
            {
                groupbox3.Visibility = Visibility.Hidden;
                rd3btn1.IsChecked = false;

                if ((string)heaterstatus.Content == "OFF")
                {
                    heatersound.Open(new Uri("../../sounds/beep.wav", UriKind.Relative));
                    heatersound.Play();

                    heaterstatus.Content = "ON";
                }
                else
                {
                    MessageBox.Show("Συγνώμη, ο Θερμοσίφωνας είναι ήδη ανοικτός.");
                }
            }
            else if (rd3btn2.IsChecked == true)
            {
                groupbox3.Visibility = Visibility.Hidden;
                rd3btn2.IsChecked = false;

                if(fan.Visibility == Visibility.Hidden)
                {
                    fansound.Open(new Uri("../../sounds/fan.mp3", UriKind.Relative));
                    fansound.Play();
                    fan.Visibility = Visibility.Visible;
                }
                else
                {
                    MessageBox.Show("Συγνώμη, ο εξαερισμός ήδη λειτουργεί.");
                }

            }
            else if (rd3btn3.IsChecked == true)
            {
                groupbox3.Visibility = Visibility.Hidden;
                rd3btn3.IsChecked = false;

                if (fan.Visibility == Visibility.Visible)
                {
                    fansound.Stop();
                    fan.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("Συγνώμη, ο εξαερισμός είναι ήδη απενεργοποιημένος.");
                }

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            groupbox3.Visibility = Visibility.Hidden;
        }

        private void trainerbtn_Click(object sender, RoutedEventArgs e)
        {
            groupbox3.Visibility = Visibility.Visible;
        }

        private void toExercisebtn_Click(object sender, RoutedEventArgs e)
        {
            fansound.Stop();
            this.NavigationService.Navigate(new exercise());
        }

        private void toPoolbtn_Click(object sender, RoutedEventArgs e)
        {
            fansound.Stop();
            this.NavigationService.Navigate(new pool());
        }

        private void toBarbtn_Click(object sender, RoutedEventArgs e)
        {
            fansound.Stop();
            this.NavigationService.Navigate(new bar());
        }

    }
}
