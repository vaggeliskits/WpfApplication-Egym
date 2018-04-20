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
    /// Interaction logic for bar_help.xaml
    /// </summary>
    public partial class bar_help : Page
    {
        public bar_help()
        {
            InitializeComponent();
        }

        private void cashier_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ στο Ταμείο, μπορείτε να επιλέξετε κάποιο ρόφημα ή σνακ, ή ακόμα και να ζητήσετε κάποια εξυπηρέτηση.");
        }

        private void wcbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ εδώ, μεταφέρεστε στο WC.");
        }

        private void toExercise_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ εδώ, μεταφέρεστε στον Χώρο Εκγύμνασης.");
        }

        private void toPool_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ εδώ, μεταφέρεστε στην Πισίνα.");
        }

        private void toLockers_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ εδώ, μεταφέρεστε στα Αποδυτήρια.");
        }

        private void exithelpbtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
