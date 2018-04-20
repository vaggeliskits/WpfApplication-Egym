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
    /// Interaction logic for pool2.xaml
    /// </summary>
    public partial class pool2 : Page
    {
        DispatcherTimer pool2timerc = new DispatcherTimer();

        MediaPlayer pool2music = new MediaPlayer();
        MediaPlayer therm2sound = new MediaPlayer();

        public pool2()
        {
            InitializeComponent();

            pool2timerc.Tick += new EventHandler(pool2timerc_tick);
            pool2timerc.Interval = new TimeSpan(0, 0, 0, 1);
            pool2timerc.Start();

            pool2music.Open(new Uri("../../sounds/poolmusic.mp3", UriKind.Relative));
            pool2music.Volume = 0.05;
            pool2music.Play();
        }

        int pool2counter = 0;
        public void pool2timerc_tick(object sender, EventArgs e)
        {
            pool2counter++;
            if (pool2counter == 5)
            {
                groupboxc4.Visibility = Visibility.Visible;
            }
            else if (pool2counter == 25)
            {
                groupboxc5.Visibility = Visibility.Visible;
            }
            else if (pool2counter == 45)
            {
                groupboxc6.Visibility = Visibility.Visible;
            }
        }

        int y = 0;      //variable used for checking
        //customer5 service dialog
        private void c5btn_Click(object sender, RoutedEventArgs e)
        {
            if (poolvalue2 == 0)
            {
                lblc5.Content = "Μπορείς να χαμηλώσεις\nτον φωτισμό;";
                y = 1;
                c5btn.Visibility = Visibility.Hidden;
            }
            else
            {
                lblc5.Content = "Μπορείς να δυναμώσεις\nτον φωτισμό;";
                y = 2;
                c5btn.Visibility = Visibility.Hidden;
            }

            if ((string)c5btn.Content == "Να'σαι καλά!")        //check made for hiding dialog when request is satisfied
            {
                groupboxc5.Visibility = Visibility.Hidden;
                c5btn.Content = "Βεβαίως!";
            }
        }

        //lights control
        int poolvalue2 = 0;
        private void poolslider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var poolslider = sender as Slider;
            double pool_svalue = poolslider.Value;

            if (pool_svalue == 0)
            {
                var pool2brush = new ImageBrush();
                pool2brush.ImageSource = new BitmapImage(new Uri("../../images/pool1.jpg", UriKind.Relative));
                pool2grid.Background = pool2brush;
                poolvalue2 = 0;
                if (y == 2)                             //the following happen in case customer5 has made a request
                {
                    lblc5.Content = "Ευχαριστώ!";
                    c5btn.Content = "Να'σαι καλά!";
                    c5btn.Visibility = Visibility.Visible;
                    y = 0;
                }
            }
            else
            {
                var pool2brush1 = new ImageBrush();
                pool2brush1.ImageSource = new BitmapImage(new Uri("../../images/pool2.jpg", UriKind.Relative));
                pool2grid.Background = pool2brush1;
                poolvalue2 = 1;
                if (y == 1)                //the following happen in case customer2 has made a request
                {
                    lblc5.Content = "Ευχαριστώ!";
                    c5btn.Content = "Να'σαι καλά!";
                    c5btn.Visibility = Visibility.Visible;
                    y = 0;
                }
            }
        }

        int x = 0;      //variable used for checking
        //customer4 service dialog
        private void c4btn_Click(object sender, RoutedEventArgs e)
        {
            if ((string)lbltemp2.Content == "25 °C")
            {
                lblc4.Content = "Μπορείς να ανεβάσεις\nτη θερμοκρασία του νερού;";
                x = 1;
                c4btn.Visibility = Visibility.Hidden;
            }
            else
            {
                lblc4.Content = "Μπορείς να χαμηλώσεις\nτη θερμοκρασία του νερού;";
                x = 2;
                c4btn.Visibility = Visibility.Hidden;
            }

            if ((string)c4btn.Content == "Να'σαι καλά!")        //check made for hiding dialog when request is satisfied
            {
                groupboxc4.Visibility = Visibility.Hidden;
                c4btn.Content = "Βεβαίως!";
            }
        }

        //pool temperature control
        private void pooltempbtn_Click(object sender, RoutedEventArgs e)
        {
            if ((string)lbltemp2.Content == "25 °C")
            {
                therm2sound.Open(new Uri("../../sounds/beep.wav", UriKind.Relative));
                therm2sound.Play();

                lbltemp2.Content = "28 °C";
                if (x == 1)                 //the following happen in case customer3 has made a request
                {
                    lblc4.Content = "Ευχαριστώ!";
                    c4btn.Content = "Να'σαι καλά!";
                    c4btn.Visibility = Visibility.Visible;
                    x = 0;
                }
            }
            else
            {
                therm2sound.Open(new Uri("../../sounds/beep.wav", UriKind.Relative));
                therm2sound.Play();

                lbltemp2.Content = "25 °C";
                if (x == 2)             //the following happen in case customer3 has made a request
                {
                    lblc4.Content = "Ευχαριστώ!";
                    c4btn.Content = "Να'σαι καλά!";
                    c4btn.Visibility = Visibility.Visible;
                    x = 0;
                }
            }
        }

        //customer6 service dialog
        private void c6btn_Click(object sender, RoutedEventArgs e)
        {
            if ((string)c6btn.Content == "Βεβαίως!")
            {
                lblc6.Content = "Τι περιλαμβάνει\nτο σημερινό μου πρόγραμμα;";
                c6btn.Content = "Για να δω...";
            }
            else if ((string)c6btn.Content == "Για να δω...")
            {
                int poold = (int)System.DateTime.Now.DayOfWeek;

                //c6btn.Visibility = Visibility.Hidden;
                switch (poold)
                {
                    case 1:
                        MessageBox.Show("Σήμερα, Δευτέρα, το πρόγραμμά σου περιλαμβάνει 200m ύπτιο.");
                        break;
                    case 2:
                        MessageBox.Show("Σήμερα, Τρίτη, το πρόγραμμά σου περιλαμβάνει 200m πρόσθιο.");
                        break;
                    case 3:
                        MessageBox.Show("Σήμερα, Τετάρτη, το πρόγραμμά σου περιλαμβάνει 150m ελεύθερο.");
                        break;
                    case 4:
                        MessageBox.Show("Σήμερα, Πέμπτη, το πρόγραμμά σου περιλαμβάνει 300m πεταλούδα.");
                        break;
                    case 5:
                        MessageBox.Show("Σήμερα, Παρασκευή, το πρόγραμμά σου περιλαμβάνει 100m ύπτιο και 100m ελεύθερο.");
                        break;
                    case 6:
                        MessageBox.Show("Σήμερα, Σάββατο, το πρόγραμμά σου περιλαμβάνει 100m πρόσθιο και 100m πεταλούδα.");
                        break;
                    case 7:
                        MessageBox.Show("Σήμερα, Κυριακή, το πρόγραμμά σου περιλαμβάνει 150m ελεύθερο.");
                        break;
                }
                lblc6.Content = "Ωραίος!";
                c6btn.Content = "Να'σαι καλα!";
            }
            else
            {
                groupboxc6.Visibility = Visibility.Hidden;
            }
        }

        private void toExercise2btn_Click(object sender, RoutedEventArgs e)
        {
            pool2music.Stop();
            this.NavigationService.Navigate(new exercise2());
        }

        private void toBar2btn_Click(object sender, RoutedEventArgs e)
        {
            pool2music.Stop();
            this.NavigationService.Navigate(new bar2());
        }

        private void toLockers2btn_Click(object sender, RoutedEventArgs e)
        {
            pool2music.Stop();
            this.NavigationService.Navigate(new lockers2());
        }

    }
}
