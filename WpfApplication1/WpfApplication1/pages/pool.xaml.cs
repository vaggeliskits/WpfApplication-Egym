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
    /// Interaction logic for pool.xaml
    /// </summary>
    public partial class pool : Page
    {
        MediaPlayer poolmusic = new MediaPlayer();
        MediaPlayer thermsound = new MediaPlayer();

        public pool()
        {
            InitializeComponent();

            poolmusic.Open(new Uri("../../sounds/poolmusic.mp3", UriKind.Relative));
            poolmusic.Volume = 0.05;
            poolmusic.Play();
        }

        private void pooltrainerbtn_Click(object sender, RoutedEventArgs e)
        {
            groupbox3.Visibility = Visibility.Visible;
        }

        int valuepool;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (poolrdbtn1.IsChecked == true)
            {
                groupbox3.Visibility = Visibility.Hidden;
                poolrdbtn1.IsChecked = false;

                if (valuepool == 0)
                {
                    var poolbrush1 = new ImageBrush();
                    poolbrush1.ImageSource = new BitmapImage(new Uri("../../images/pool2.jpg", UriKind.Relative));
                    poolgrid.Background = poolbrush1;
                    valuepool = 1;
                }
                else
                {
                    MessageBox.Show("Συγνώμη, ο φωτισμός δεν μπορεί να γίνει χαμηλότερος.");
                }
            }
            else if (poolrdbtn2.IsChecked == true)
            {
                groupbox3.Visibility = Visibility.Hidden;
                poolrdbtn2.IsChecked = false;

                if (valuepool == 1)
                {
                    var poolbrush = new ImageBrush();
                    poolbrush.ImageSource = new BitmapImage(new Uri("../../images/pool1.jpg", UriKind.Relative));
                    poolgrid.Background = poolbrush;
                    valuepool = 0;
                }
                else
                {
                    MessageBox.Show("Συγνώμη, ο φωτισμός δεν δυναμώνει παραπάνω.");
                }
            }
            else if (poolrdbtn3.IsChecked == true)
            {
                groupbox3.Visibility = Visibility.Hidden;
                poolrdbtn3.IsChecked = false;

                if ((string)lbltemp.Content == "25 °C")
                {
                    thermsound.Open(new Uri("../../sounds/beep.wav", UriKind.Relative));
                    thermsound.Play();

                    lbltemp.Content = "28 °C";
                }
                else
                {
                    MessageBox.Show("Η θερμοκρασία είναι ήδη ανεβασμένη.");
                }
            }
            else if (poolrdbtn4.IsChecked == true)
            {
                groupbox3.Visibility = Visibility.Hidden;
                poolrdbtn4.IsChecked = false;

                if ((string)lbltemp.Content == "28 °C")
                {
                    thermsound.Open(new Uri("../../sounds/beep.wav", UriKind.Relative));
                    thermsound.Play();

                    lbltemp.Content = "25 °C";
                }
                else
                {
                    MessageBox.Show("Η θερμοκρασία είναι ήδη χαμηλή.");
                }

            }
            else if (poolrdbtn5.IsChecked == true)
            {
                int poold = (int)System.DateTime.Now.DayOfWeek;

                groupbox3.Visibility = Visibility.Hidden;
                poolrdbtn5.IsChecked = false;

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
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            groupbox3.Visibility = Visibility.Hidden;
        }

        private void swimbtn_Click(object sender, RoutedEventArgs e)
        {
            SwimmingWindow swim = new SwimmingWindow();
            swim.ShowDialog();
        }

        private void pooltoExercisebtn_Click(object sender, RoutedEventArgs e)
        {
            poolmusic.Stop();
            this.NavigationService.Navigate(new exercise());
        }

        private void pooltoBarbtn_Click(object sender, RoutedEventArgs e)
        {
            poolmusic.Stop();
            this.NavigationService.Navigate(new bar());
        }

        private void pooltoLockersbtn_Click(object sender, RoutedEventArgs e)
        {
            poolmusic.Stop();
            this.NavigationService.Navigate(new lockers());
        }

        
    }
}
