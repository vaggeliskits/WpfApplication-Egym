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
    /// Interaction logic for pool_help.xaml
    /// </summary>
    public partial class pool_help : Page
    {
        public pool_help()
        {
            InitializeComponent();
        }

        private void exithelpbtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void pooltrainer_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ στον γυμναστή, εμφανίζεται μια λίστα επιλογών εξυπηρέτησης (π.χ. ρύθμιση φωτισμού κ.λπ.).");
        }

        private void swim_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Kάνοντας κλικ στην πισίνα, ενεργοποιείται ένα παράθυρο στο οποίο εισάγετε τα μέτρα που επιθυμείτε να διανύσετε κολυμπώντας και έπειτα κάνετε κλικ στο κουμπί 'OK' για να ξεκινήσετε να γυμνάζεστε.");
        }

        private void pooltoExercise_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ εδώ, μεταφέρεστε στον Χώρο Εκγύμνασης.");
        }

        private void pooltoBar_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ εδώ, μεταφέρεστε στο Μπαρ.");
        }

        private void pooltoLockers_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ εδώ, μεταφέρεστε στα Αποδυτήρια.");
        }
    }
}
