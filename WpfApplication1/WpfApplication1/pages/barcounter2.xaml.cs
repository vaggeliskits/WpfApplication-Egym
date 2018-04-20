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
    /// Interaction logic for barcounter2.xaml
    /// </summary>
    public partial class barcounter2 : Page
    {
        MediaPlayer coin2sound = new MediaPlayer();

        public barcounter2()
        {
            InitializeComponent();
        }

        private void viewmenubtn_Click(object sender, RoutedEventArgs e)
        {
            groupboxmenu2.Visibility = Visibility.Visible;
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        double total2 = 0.00;

        private void closemenu2btn_Click(object sender, RoutedEventArgs e)
        {
            groupboxmenu2.Visibility = Visibility.Hidden;
            menu2check1.IsChecked = false;
            menu2check2.IsChecked = false;
            menu2check3.IsChecked = false;
            menu2check4.IsChecked = false;
            menu2check5.IsChecked = false;
            menu2check6.IsChecked = false;
            menu2check7.IsChecked = false;
            menu2check8.IsChecked = false;
            menu2check9.IsChecked = false;
            menu2check10.IsChecked = false;
            total2 = 0.00;
            totallbl2.Content = total2;
            discountlbl2.Content = total2 * 0.3;
            finallbl2.Content = total2 * 0.7;
        }

        private void payment2btn_Click(object sender, RoutedEventArgs e)
        {
            if (total2 == 0.00)
            {
                MessageBox.Show("Πρέπει να επιλέξεις κάτι για να πληρώσεις!");
            }
            else
            {
                menu2check1.IsChecked = false;
                menu2check2.IsChecked = false;
                menu2check3.IsChecked = false;
                menu2check4.IsChecked = false;
                menu2check5.IsChecked = false;
                menu2check6.IsChecked = false;
                menu2check7.IsChecked = false;
                menu2check8.IsChecked = false;
                menu2check9.IsChecked = false;
                menu2check10.IsChecked = false;
                coin2sound.Open(new Uri("../../sounds/coins.wav", UriKind.Relative));
                coin2sound.Play();
                MessageBox.Show("Να'σαι καλά! Τα λέμε, καλή συνέχεια!");
                groupboxmenu2.Visibility = Visibility.Hidden;
            }
        }

        private void cancelmenu2btn_Click(object sender, RoutedEventArgs e)
        {
            menu2check1.IsChecked = false;
            menu2check2.IsChecked = false;
            menu2check3.IsChecked = false;
            menu2check4.IsChecked = false;
            menu2check5.IsChecked = false;
            menu2check6.IsChecked = false;
            menu2check7.IsChecked = false;
            menu2check8.IsChecked = false;
            menu2check9.IsChecked = false;
            menu2check10.IsChecked = false;
            total2 = 0.00;
            totallbl2.Content = total2;
            discountlbl2.Content = total2 * 0.3;
            finallbl2.Content = total2 * 0.7;
        }

        //charge according to selection of menu products
        private void menu2check1_Checked(object sender, RoutedEventArgs e)
        {
            total2 += 0.50;
            totallbl2.Content = total2;
            discountlbl2.Content = total2 * 0.3;
            finallbl2.Content = total2 * 0.7;
        }

        private void menu2check1_Unchecked(object sender, RoutedEventArgs e)
        {
            total2 -= 0.50;
            totallbl2.Content = total2;
            discountlbl2.Content = total2 * 0.3;
            finallbl2.Content = total2 * 0.7;
        }

        private void menu2check2_Checked(object sender, RoutedEventArgs e)
        {
            total2 += 2.50;
            totallbl2.Content = total2;
            discountlbl2.Content = total2 * 0.3;
            finallbl2.Content = total2 * 0.7;
        }

        private void menu2check2_Unchecked(object sender, RoutedEventArgs e)
        {
            total2 -= 2.50;
            totallbl2.Content = total2;
            discountlbl2.Content = total2 * 0.3;
            finallbl2.Content = total2 * 0.7;
        }

        private void menu2check3_Checked(object sender, RoutedEventArgs e)
        {
            total2 += 1.50;
            totallbl2.Content = total2;
            discountlbl2.Content = total2 * 0.3;
            finallbl2.Content = total2 * 0.7;
        }

        private void menu2check3_Unchecked(object sender, RoutedEventArgs e)
        {
            total2 -= 1.50;
            totallbl2.Content = total2;
            discountlbl2.Content = total2 * 0.3;
            finallbl2.Content = total2 * 0.7;
        }

        private void menu2check4_Checked(object sender, RoutedEventArgs e)
        {
            total2 += 1.90;
            totallbl2.Content = total2;
            discountlbl2.Content = total2 * 0.3;
            finallbl2.Content = total2 * 0.7;
        }

        private void menu2check4_Unchecked(object sender, RoutedEventArgs e)
        {
            total2 -= 1.90;
            totallbl2.Content = total2;
            discountlbl2.Content = total2 * 0.3;
            finallbl2.Content = total2 * 0.7;
        }

        private void menu2check5_Checked(object sender, RoutedEventArgs e)
        {
            total2 += 2.20;
            totallbl2.Content = total2;
            discountlbl2.Content = total2 * 0.3;
            finallbl2.Content = total2 * 0.7;
        }

        private void menu2check5_Unchecked(object sender, RoutedEventArgs e)
        {
            total2 -= 2.20;
            totallbl2.Content = total2;
            discountlbl2.Content = total2 * 0.3;
            finallbl2.Content = total2 * 0.7;
        }

        private void menu2check6_Checked(object sender, RoutedEventArgs e)
        {
            total2 += 1.00;
            totallbl2.Content = total2;
            discountlbl2.Content = total2 * 0.3;
            finallbl2.Content = total2 * 0.7;
        }

        private void menu2check6_Unchecked(object sender, RoutedEventArgs e)
        {
            total2 -= 1.00;
            totallbl2.Content = total2;
            discountlbl2.Content = total2 * 0.3;
            finallbl2.Content = total2 * 0.7;
        }

        private void menu2check7_Checked(object sender, RoutedEventArgs e)
        {
            total2 += 1.50;
            totallbl2.Content = total2;
            discountlbl2.Content = total2 * 0.3;
            finallbl2.Content = total2 * 0.7;
        }

        private void menu2check7_Unchecked(object sender, RoutedEventArgs e)
        {
            total2 -= 1.50;
            totallbl2.Content = total2;
            discountlbl2.Content = total2 * 0.3;
            finallbl2.Content = total2 * 0.7;
        }

        private void menu2check8_Checked(object sender, RoutedEventArgs e)
        {
            total2 += 1.20;
            totallbl2.Content = total2;
            discountlbl2.Content = total2 * 0.3;
            finallbl2.Content = total2 * 0.7;
        }

        private void menu2check8_Unchecked(object sender, RoutedEventArgs e)
        {
            total2 -= 1.20;
            totallbl2.Content = total2;
            discountlbl2.Content = total2 * 0.3;
            finallbl2.Content = total2 * 0.7;
        }

        private void menu2check9_Checked(object sender, RoutedEventArgs e)
        {
            total2 += 3.60;
            totallbl2.Content = total2;
            discountlbl2.Content = total2 * 0.3;
            finallbl2.Content = total2 * 0.7;
        }

        private void menu2check9_Unchecked(object sender, RoutedEventArgs e)
        {
            total2 -= 3.60;
            totallbl2.Content = total2;
            discountlbl2.Content = total2 * 0.3;
            finallbl2.Content = total2 * 0.7;
        }

        private void menu2check10_Checked(object sender, RoutedEventArgs e)
        {
            total2 += 3.80;
            totallbl2.Content = total2;
            discountlbl2.Content = total2 * 0.3;
            finallbl2.Content = total2 * 0.7;
        }

        private void menu2check10_Unchecked(object sender, RoutedEventArgs e)
        {
            total2 -= 3.80;
            totallbl2.Content = total2;
            discountlbl2.Content = total2 * 0.3;
            finallbl2.Content = total2 * 0.7;
        }

    }
}
