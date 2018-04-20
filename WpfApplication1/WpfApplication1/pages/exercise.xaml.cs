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
    /// Interaction logic for exercise.xaml
    /// </summary>

    public partial class exercise : Page
    {
        MediaPlayer exercisemusic = new MediaPlayer();
        MediaPlayer acsound = new MediaPlayer();

        public exercise()
        {
            InitializeComponent();

            exercisemusic.Open(new Uri("../../sounds/exercisemusic.mp3", UriKind.Relative));
            exercisemusic.Volume = 0.1;
            exercisemusic.Play();
        }

        private void legbtn_Click(object sender, RoutedEventArgs e)
        {
            RepeatsWindow rep = new RepeatsWindow();
            rep.ShowDialog();
        }

        private void shoulderpressbtn_Click(object sender, RoutedEventArgs e)
        {
            RepeatsWindow rep = new RepeatsWindow();
            rep.ShowDialog();
        }

        private void weigthsbtn_Click(object sender, RoutedEventArgs e)
        {
            RepeatsWindow rep = new RepeatsWindow();
            rep.ShowDialog();
        }

        private void ballsbtn_Click(object sender, RoutedEventArgs e)
        {
            RepeatsWindow rep = new RepeatsWindow();
            rep.ShowDialog();
        }

        private void pulleybtn_Click(object sender, RoutedEventArgs e)
        {
            RepeatsWindow rep = new RepeatsWindow();
            rep.ShowDialog();
        }

        private void diadromosbtn_Click(object sender, RoutedEventArgs e)
        {
            Panel pnl = new Panel();
            pnl.ShowDialog();
        }

        private void podilatobtn1_Click(object sender, RoutedEventArgs e)
        {
            Panel pnl = new Panel();
            pnl.ShowDialog();
        }

        private void podilatobtn2_Click(object sender, RoutedEventArgs e)
        {
            Panel pnl = new Panel();
            pnl.ShowDialog();
        }

        private void elleiptikobtn1_Click(object sender, RoutedEventArgs e)
        {
            Panel pnl = new Panel();
            pnl.ShowDialog();
        }

        private void elleiptikobtn2_Click(object sender, RoutedEventArgs e)
        {
            Panel pnl = new Panel();
            pnl.ShowDialog();
        }

        private void trainerbtn_Click(object sender, RoutedEventArgs e)
        {
            groupbox1.Visibility = Visibility.Visible;
        }

        //dialog with trainer
        int value;  //class variable for lights check

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (rdbtn1.IsChecked == true)
            {
                groupbox1.Visibility = Visibility.Hidden;
                rdbtn1.IsChecked = false;

                if (value == 0)
                {
                    var brush1 = new ImageBrush();
                    brush1.ImageSource = new BitmapImage(new Uri("../../images/exercise2.jpg", UriKind.Relative));
                    maingrid.Background = brush1;
                    value = 1;                    
                }
                else if (value == 1)
                {
                    var brush2 = new ImageBrush();
                    brush2.ImageSource = new BitmapImage(new Uri("../../images/exercise3.jpg", UriKind.Relative));
                    maingrid.Background = brush2;
                    value = 2;
                }
                else
                {
                    MessageBox.Show("Συγνώμη, ο φωτισμός δεν μπορεί να γίνει χαμηλότερος.");
                }               
            }
            else if (rdbtn2.IsChecked == true)
            {
                groupbox1.Visibility = Visibility.Hidden;
                rdbtn2.IsChecked = false;

                if (value == 2)
                {
                    var brush1 = new ImageBrush();
                    brush1.ImageSource = new BitmapImage(new Uri("../../images/exercise2.jpg", UriKind.Relative));
                    maingrid.Background = brush1;
                    value = 1;
                }
                else if (value == 1)
                {
                    var brush = new ImageBrush();
                    brush.ImageSource = new BitmapImage(new Uri("../../images/exercise1.jpg", UriKind.Relative));
                    maingrid.Background = brush;
                    value = 0;
                }
                else
                {
                    MessageBox.Show("Συγνώμη, ο φωτισμός δεν δυναμώνει παραπάνω.");
                }
            }
            else if (rdbtn3.IsChecked == true)
            {
                groupbox1.Visibility = Visibility.Hidden;
                rdbtn3.IsChecked = false;

                if ((string)acstatus.Content == "OFF")
                {
                    acstatus.Content = "ON";
                    acsound.Open(new Uri("../../sounds/beep.wav", UriKind.Relative));
                    acsound.Play();
                }
                else
                {
                    MessageBox.Show("Το κλιματιστικό είναι ήδη ενεργοποιημένο.");
                }
            }
            else if (rdbtn4.IsChecked == true)
            {
                groupbox1.Visibility = Visibility.Hidden;
                rdbtn4.IsChecked = false;

                if ((string)acstatus.Content == "ON")
                {
                    acstatus.Content = "OFF";
                    acsound.Open(new Uri("../../sounds/beep.wav", UriKind.Relative));
                    acsound.Play();
                }
                else
                {
                    MessageBox.Show("Το κλιματιστικό είναι ήδη απενεργοποιημένο.");
                }
            }
            else if (rdbtn5.IsChecked == true)
            {
                int d = (int)System.DateTime.Now.DayOfWeek;

                groupbox1.Visibility = Visibility.Hidden;
                rdbtn5.IsChecked = false;

                switch(d)
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
             }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            groupbox1.Visibility = Visibility.Hidden;
        }

        private void toPoolbtn_Click(object sender, RoutedEventArgs e)
        {
            exercisemusic.Stop();
            this.NavigationService.Navigate(new pool());
        }

        private void toBarbtn_Click(object sender, RoutedEventArgs e)
        {
            exercisemusic.Stop();
            this.NavigationService.Navigate(new bar());
        }

        private void toLockersbtn_Click(object sender, RoutedEventArgs e)
        {
            exercisemusic.Stop();
            this.NavigationService.Navigate(new lockers());
        }

    }
}
