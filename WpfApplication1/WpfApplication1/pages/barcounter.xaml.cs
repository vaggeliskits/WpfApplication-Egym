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
    /// Interaction logic for barcounter.xaml
    /// </summary>
    public partial class barcounter : Page
    {
        private   MediaElement tvscreen;

        MediaPlayer coinsound = new MediaPlayer();

        public barcounter(MediaElement tvscreen)
        {
            InitializeComponent();
            this.tvscreen = tvscreen;
        }
        
        private void selectbtn_Click(object sender, RoutedEventArgs e)
        {
            if (barrdbtn1.IsChecked == true)
            {
                barrdbtn1.IsChecked = false;
                groupboxmenu.Visibility = Visibility.Visible;
            }
            else if (barrdbtn2.IsChecked == true)
            {
                barrdbtn2.IsChecked = false;

                if (tvscreen.Visibility == Visibility.Hidden)
                {
                    MessageBox.Show("Βεβαίως!");
                    tvscreen.Visibility = Visibility.Visible;
                }
                else
                {
                    MessageBox.Show("Συγνώμη, αλλά η τηλεόραση ειναι ήδη ανοικτή!");
                }
            }
            else if (barrdbtn3.IsChecked == true)
            {
                barrdbtn3.IsChecked = false;

                if (tvscreen.Visibility == Visibility.Visible)
                {
                    MessageBox.Show("Βεβαίως!");
                    tvscreen.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("Συγνώμη, αλλά η τηλεόραση ειναι ήδη κλειστή!");
                }
            }
            else if (barrdbtn4.IsChecked == true)
            {
                barrdbtn4.IsChecked = false;

                MessageBox.Show("Στην τρίτη πόρτα αριστερά,\nπριν μπείτε στον χώρο εκγύμνασης.");
            }
        }

        private void returnbtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void closemenubtn_Click(object sender, RoutedEventArgs e)
        {
            groupboxmenu.Visibility = Visibility.Hidden;
            menucheck1.IsChecked = false;
            menucheck2.IsChecked = false;
            menucheck3.IsChecked = false;
            menucheck4.IsChecked = false;
            menucheck5.IsChecked = false;
            menucheck6.IsChecked = false;
            menucheck7.IsChecked = false;
            menucheck8.IsChecked = false;
            menucheck9.IsChecked = false;
            menucheck10.IsChecked = false;
            total = 0.00;
            totallbl.Content = total;
        }

        private void paymentbtn_Click(object sender, RoutedEventArgs e)
        {
            if (total == 0.00)
            {
                MessageBox.Show("Δεν έχετε επιλέξει κάτι για να πληρώσετε.");
            }
            else
            {
                menucheck1.IsChecked = false;
                menucheck2.IsChecked = false;
                menucheck3.IsChecked = false;
                menucheck4.IsChecked = false;
                menucheck5.IsChecked = false;
                menucheck6.IsChecked = false;
                menucheck7.IsChecked = false;
                menucheck8.IsChecked = false;
                menucheck9.IsChecked = false;
                menucheck10.IsChecked = false;
                coinsound.Open(new Uri("../../sounds/coins.wav", UriKind.Relative));
                coinsound.Play();
                MessageBox.Show("Ευχαριστούμε πολύ! Καλή σας απόλαυση!");
                groupboxmenu.Visibility = Visibility.Hidden;
            }
        }

        private void cancelmenubtn_Click(object sender, RoutedEventArgs e)
        {
            menucheck1.IsChecked = false;
            menucheck2.IsChecked = false;
            menucheck3.IsChecked = false;
            menucheck4.IsChecked = false;
            menucheck5.IsChecked = false;
            menucheck6.IsChecked = false;
            menucheck7.IsChecked = false;
            menucheck8.IsChecked = false;
            menucheck9.IsChecked = false;
            menucheck10.IsChecked = false;
            total = 0.00;
            totallbl.Content = total;
        }

        double total = 0.00;

        //charge according to selection of menu products
        private void menucheck1_Checked(object sender, RoutedEventArgs e)
        {
            total += 0.50;
            totallbl.Content = total;
        }

        private void menucheck1_Unchecked(object sender, RoutedEventArgs e)
        {
            total -= 0.50;
            totallbl.Content = total;
        }

        private void menucheck2_Checked(object sender, RoutedEventArgs e)
        {
            total += 2.50;
            totallbl.Content = total;
        }

        private void menucheck2_Unchecked(object sender, RoutedEventArgs e)
        {
            total -= 2.50;
            totallbl.Content = total;
        }

        private void menucheck3_Checked(object sender, RoutedEventArgs e)
        {
            total += 1.50;
            totallbl.Content = total;
        }

        private void menucheck3_Unchecked(object sender, RoutedEventArgs e)
        {
            total -= 1.50;
            totallbl.Content = total;
        }

        private void menucheck4_Checked(object sender, RoutedEventArgs e)
        {
            total += 1.90;
            totallbl.Content = total;
        }

        private void menucheck4_Unchecked(object sender, RoutedEventArgs e)
        {
            total -= 1.90;
            totallbl.Content = total;
        }

        private void menucheck5_Checked(object sender, RoutedEventArgs e)
        {
            total += 2.20;
            totallbl.Content = total;
        }

        private void menucheck5_Unchecked(object sender, RoutedEventArgs e)
        {
            total -= 2.20;
            totallbl.Content = total;
        }

        private void menucheck6_Checked(object sender, RoutedEventArgs e)
        {
            total += 1.00;
            totallbl.Content = total;
        }

        private void menucheck6_Unchecked(object sender, RoutedEventArgs e)
        {
            total -= 1.00;
            totallbl.Content = total;
        }

        private void menucheck7_Checked(object sender, RoutedEventArgs e)
        {
            total += 1.50;
            totallbl.Content = total;
        }

        private void menucheck7_Unchecked(object sender, RoutedEventArgs e)
        {
            total -= 1.50;
            totallbl.Content = total;
        }

        private void menucheck8_Checked(object sender, RoutedEventArgs e)
        {
            total += 1.20;
            totallbl.Content = total;
        }

        private void menucheck8_Unchecked(object sender, RoutedEventArgs e)
        {
            total -= 1.20;
            totallbl.Content = total;
        }

        private void menucheck9_Checked(object sender, RoutedEventArgs e)
        {
            total += 3.60;
            totallbl.Content = total;
        }

        private void menucheck9_Unchecked(object sender, RoutedEventArgs e)
        {
            total -= 3.60;
            totallbl.Content = total;
        }

        private void menucheck10_Checked(object sender, RoutedEventArgs e)
        {
            total += 3.80;
            totallbl.Content = total;
        }

        private void menucheck10_Unchecked(object sender, RoutedEventArgs e)
        {
            total -= 3.80;
            totallbl.Content = total;
        }

        
    }
}
