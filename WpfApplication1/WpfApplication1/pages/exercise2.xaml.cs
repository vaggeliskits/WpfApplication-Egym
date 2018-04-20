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
    /// Interaction logic for exercise2.xaml
    /// </summary>
    public partial class exercise2 : Page
    {
        DispatcherTimer timerc = new DispatcherTimer();

        MediaPlayer exercise2music = new MediaPlayer();
        MediaPlayer ac2sound = new MediaPlayer();
                
        public exercise2()
        {
            InitializeComponent();

            timerc.Tick += new EventHandler(timerc_tick);
            timerc.Interval = new TimeSpan(0, 0, 0, 1);
            timerc.Start();

            exercise2music.Open(new Uri("../../sounds/exercisemusic.mp3", UriKind.Relative));
            exercise2music.Volume = 0.1;
            exercise2music.Play();
        }

        int counter = 0;
        public void timerc_tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 5)
            {
                groupboxc3.Visibility = Visibility.Visible;
            }
            else if (counter == 25)
            {
                groupboxc2.Visibility = Visibility.Visible;
            }
            else if (counter == 45)
            {
                groupboxc1.Visibility = Visibility.Visible;
            }
        }


        int y = 0;      //variable used for checking
        //customer2 service dialog
        private void c2btn_Click(object sender, RoutedEventArgs e)
        {
            if (value2 == 0)
            {
                lblc2.Content = "Μπορείς να χαμηλώσεις τον φωτισμό;";
                y = 1;
                c2btn.Visibility = Visibility.Hidden;
            }
            else
            {
                lblc2.Content = "Μπορείς να δυναμώσεις τον φωτισμό;";
                y = 2;
                c2btn.Visibility = Visibility.Hidden;
            }

            if ((string)c2btn.Content == "Να'σαι καλά!")        //check made for hiding dialog when request is satisfied
            {
                groupboxc2.Visibility = Visibility.Hidden;
                c3btn.Content = "Βεβαίως!";
            }
        }

        //lights control
        int value2 = 0;
        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            double svalue = slider.Value;
            
            if (svalue == 0)
            {
                var brush = new ImageBrush();
                brush.ImageSource = new BitmapImage(new Uri("../../images/exercise1.jpg", UriKind.Relative));
                ex2grid.Background = brush;
                value2 = 0;
                if (y == 2)                             //the following happen in case customer2 has made a request
                {
                    lblc2.Content = "Ευχαριστώ!";
                    c2btn.Content = "Να'σαι καλά!";
                    c2btn.Visibility = Visibility.Visible;
                    y = 0;
                }
            }
            else
            {
                var brush1 = new ImageBrush();
                brush1.ImageSource = new BitmapImage(new Uri("../../images/exercise2.jpg", UriKind.Relative));
                ex2grid.Background = brush1;
                value2 = 1;
                if ((y == 1) || (y == 2))                //the following happen in case customer2 has made a request
                {
                    lblc2.Content = "Ευχαριστώ!";
                    c2btn.Content = "Να'σαι καλά!";
                    c2btn.Visibility = Visibility.Visible;
                    y = 0;
                }
            }
        }


        int x = 0;      //variable used for checking
        //customer3 service dialog
        private void c3btn_Click(object sender, RoutedEventArgs e)
        {
            if ((string)acstatus.Content == "OFF")
            {
                lblc3.Content = "Μπορείς να ενεργοποιήσεις\nτο κλιματιστικό;";
                x = 1;
                c3btn.Visibility = Visibility.Hidden;
            }
            else
            {
                lblc3.Content = "Μπορείς να απενεργοποιήσεις\nτο κλιματιστικό;";
                x = 2;
                c3btn.Visibility = Visibility.Hidden;
            }

            if ((string)c3btn.Content == "Να'σαι καλά!")        //check made for hiding dialog when request is satisfied
            {
                groupboxc3.Visibility = Visibility.Hidden;
                c3btn.Content = "Βεβαίως!";
            }
        }

        //air condition control
        private void acbtn_Click(object sender, RoutedEventArgs e)
        {
            if((string)acstatus.Content == "OFF")
            {
                ac2sound.Open(new Uri("../../sounds/beep.wav", UriKind.Relative));
                ac2sound.Play();

                acstatus.Content = "ON";
                if (x == 1)                 //the following happen in case customer3 has made a request
                {
                    lblc3.Content = "Ευχαριστώ!";
                    c3btn.Content = "Να'σαι καλά!";
                    c3btn.Visibility = Visibility.Visible;
                    x = 0;
                }
            }
            else
            {
                ac2sound.Open(new Uri("../../sounds/beep.wav", UriKind.Relative));
                ac2sound.Play();

                acstatus.Content = "OFF";
                if (x == 2)             //the following happen in case customer3 has made a request
                {
                    lblc3.Content = "Ευχαριστώ!";
                    c3btn.Content = "Να'σαι καλά!";
                    c3btn.Visibility = Visibility.Visible;
                    x = 0;
                }
            }
        }

        //customer1 service dialog
        private void c1btn_Click(object sender, RoutedEventArgs e)
        {
            if ((string)c1btn.Content == "Βεβαίως!")
            {
                lblc1.Content = "Τι περιλαμβάνει\nτο σημερινό μου πρόγραμμα;";
                c1btn.Content = "Για να δω...";
            }
            else if ((string)c1btn.Content == "Για να δω...")
            {
                int d = (int)System.DateTime.Now.DayOfWeek;

                lblc1.Content = "Τι περιλαμβάνει\nτο σημερινό μου πρόγραμμα;";
                switch (d)
                {
                    case 1:
                        MessageBox.Show("Σήμερα, Δευτέρα, το πρόγραμμά σου περιλαμβάνει Στήθος και Δικέφαλα.");
                        break;
                    case 2:
                        MessageBox.Show("Σήμερα, Τρίτη, το πρόγραμμά σου περιλαμβάνει Πλάτη και Τρικέφαλα.");
                        break;
                    case 3:
                        MessageBox.Show("Σήμερα, Τετάρτη, το πρόγραμμά σου περιλαμβάνει Ώμους και Πόδια.");
                        break;
                    case 4:
                        MessageBox.Show("Σήμερα, Πέμπτη, το πρόγραμμά σου περιλαμβάνει Κοιλιακούς και Διάδρομο.");
                        break;
                    case 5:
                        MessageBox.Show("Σήμερα, Παρασκευή, το πρόγραμμά σου περιλαμβάνει Δικέφαλα και Τρικέφαλα.");
                        break;
                    case 6:
                        MessageBox.Show("Σήμερα, Σάββατο, το πρόγραμμά σου περιλαμβάνει Διάδρομο και Στήθος.");
                        break;
                    case 7:
                        MessageBox.Show("Σήμερα, Κυριακή, το πρόγραμμά σου περιλαμβάνει Κοιλιακούς και Πλάτη.");
                        break;
                }
                lblc1.Content = "Ευχαριστώ μεγάλε!";
                c1btn.Content = "Να'σαι καλα!";
            }
            else
            {
                groupboxc1.Visibility = Visibility.Hidden;
            }
            
        }

        private void toPool2btn_Click(object sender, RoutedEventArgs e)
        {
            exercise2music.Stop();
            this.NavigationService.Navigate(new pool2());
        }

        private void toBar2btn_Click(object sender, RoutedEventArgs e)
        {
            exercise2music.Stop();
            this.NavigationService.Navigate(new bar2());
        }

        private void toLockers2btn_Click(object sender, RoutedEventArgs e)
        {
            exercise2music.Stop();
            this.NavigationService.Navigate(new lockers2());
        }
     
    }
}
