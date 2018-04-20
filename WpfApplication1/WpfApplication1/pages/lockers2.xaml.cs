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
    /// Interaction logic for lockers2.xaml
    /// </summary>
    public partial class lockers2 : Page
    {

        DispatcherTimer lockerctimer = new DispatcherTimer();

        MediaPlayer fansound2 = new MediaPlayer();
        MediaPlayer heater2sound = new MediaPlayer();

        public lockers2()
        {
            InitializeComponent();
            lockerctimer.Tick += new EventHandler(lockerctimer_tick);
            lockerctimer.Interval = new TimeSpan(0, 0, 0, 1);
            lockerctimer.Start();
        }

        private void fan_MediaEnded(object sender, RoutedEventArgs e)
        {
            fan.Position = new TimeSpan(0, 0, 1);
            fan.Play();
        }

        int lcounter = 0;
        public void lockerctimer_tick(object sender, EventArgs e)
        {
            lcounter++;
            if (lcounter == 5)
            {
                groupboxc7.Visibility = Visibility.Visible;
            }
            else if (lcounter == 20)
            {
                groupboxc8.Visibility = Visibility.Visible;
            }
        }

        int z = 0;      //variable used for checking
        //customer7 service dialog
        private void c7btn_Click(object sender, RoutedEventArgs e)
        {
            if ((string)heaterstatus.Content == "OFF")
            {
                lblc7.Content = "Μπορείς να ανοίξεις\nτον θερμοσίφωνα;";
                z = 1;
                c7btn.Visibility = Visibility.Hidden;
            }
            else
            {
                lblc7.Content = "Μπορείς να κλείσεις\nτον θερμοσίφωνα;";
                z = 2;
                c7btn.Visibility = Visibility.Hidden;
            }

            if ((string)c7btn.Content == "Να'σαι καλά!")        //check made for hiding dialog when request is satisfied
            {
                groupboxc7.Visibility = Visibility.Hidden;
                c7btn.Content = "Βεβαίως!";
            }
        }

        private void heaterbtn_Click(object sender, RoutedEventArgs e)
        {
            if ((string)heaterstatus.Content == "OFF")
            {
                heater2sound.Open(new Uri("../../sounds/beep.wav", UriKind.Relative));
                heater2sound.Play();

                heaterstatus.Content = "ON";
                if (z == 1)                 //the following happen in case customer7 has made a request
                {
                    lblc7.Content = "Ευχαριστώ!";
                    c7btn.Content = "Να'σαι καλά!";
                    c7btn.Visibility = Visibility.Visible;
                    z = 0;
                }
            }
            else
            {
                heater2sound.Open(new Uri("../../sounds/beep.wav", UriKind.Relative));
                heater2sound.Play();

                heaterstatus.Content = "OFF";
                if (z == 2)             //the following happen in case customer7 has made a request
                {
                    lblc7.Content = "Ευχαριστώ!";
                    c7btn.Content = "Να'σαι καλά!";
                    c7btn.Visibility = Visibility.Visible;
                    z = 0;
                }
            }
        }

        int w = 0;      //variable used for checking
        //customer8 service dialog
        private void c8btn_Click(object sender, RoutedEventArgs e)
        {
            if (fan.Visibility == Visibility.Visible)
            {
                lblc8.Content = "Μπορούμε να απενεργοποιήσουμε\nτον εξαερισμό;";
                w = 1;
                c8btn.Visibility = Visibility.Hidden;
            }
            else
            {
                lblc8.Content = "Μπορούμε να ενεργοποιήσουμε\nτον εξαερισμό;";
                w = 2;
                c8btn.Visibility = Visibility.Hidden;
            }

            if ((string)c8btn.Content == "Να'σαι καλά!")        //check made for hiding dialog when request is satisfied
            {
                groupboxc8.Visibility = Visibility.Hidden;
                c8btn.Content = "Βεβαίως!";
            }
        }

        private void fanbtn_Click(object sender, RoutedEventArgs e)
        {
            if (fan.Visibility == Visibility.Visible)
            {
                fansound2.Stop();

                fan.Visibility = Visibility.Hidden;
                if (w == 1)                 //the following happen in case customer8 has made a request
                {
                    lblc8.Content = "Ευχαριστώ!";
                    c8btn.Content = "Να'σαι καλά!";
                    c8btn.Visibility = Visibility.Visible;
                    w = 0;
                }
            }
            else
            {
                fansound2.Open(new Uri("../../sounds/fan.mp3", UriKind.Relative));
                fansound2.Play();

                fan.Visibility = Visibility.Visible;
                if (w == 2)             //the following happen in case customer8 has made a request
                {
                    lblc8.Content = "Ευχαριστώ!";
                    c8btn.Content = "Να'σαι καλά!";
                    c8btn.Visibility = Visibility.Visible;
                    w = 0;
                }
            }
        }
        
        private void toExercise2btn_Click(object sender, RoutedEventArgs e)
        {
            fansound2.Stop();
            this.NavigationService.Navigate(new exercise2());
        }

        private void toPool2btn_Click(object sender, RoutedEventArgs e)
        {
            fansound2.Stop();
            this.NavigationService.Navigate(new pool2());
        }

        private void toBar2btn_Click(object sender, RoutedEventArgs e)
        {
            fansound2.Stop();
            this.NavigationService.Navigate(new bar2());
        }

    }
}
