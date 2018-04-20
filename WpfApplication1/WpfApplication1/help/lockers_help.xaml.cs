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

namespace WpfApplication1.help
{
    /// <summary>
    /// Interaction logic for lockers_help.xaml
    /// </summary>
    public partial class lockers_help : Page
    {
        public lockers_help()
        {
            InitializeComponent();
        }

        private void shower1_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ στην ντουζιέρα, μπαίνετε για ένα γρήγορο και χαλαρωτικό ντουζάκι.");
        }

        private void shower2_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ στην ντουζιέρα, μπαίνετε για ένα γρήγορο και χαλαρωτικό ντουζάκι.");
        }

        private void shower3_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ στην ντουζιέρα, μπαίνετε για ένα γρήγορο και χαλαρωτικό ντουζάκι.");
        }

        private void trainer_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ στον γυμναστή, εμφανίζεται μια λίστα επιλογών εξυπηρέτησης (π.χ. ενεργοποίηση θερμοσίφωνα κ.λπ.).");
        }

        private void toExercise_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ εδώ, μεταφέρεστε στον Χώρο Εκγύμνασης.");
        }

        private void toPool_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ εδώ, μεταφέρεστε στην Πισίνα.");
        }

        private void toBar_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ εδώ, μεταφέρεστε στο Μπαρ.");
        }

        private void exithelpbtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
