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
    /// Interaction logic for bar2_help.xaml
    /// </summary>
    public partial class bar2_help : Page
    {
        public bar2_help()
        {
            InitializeComponent();
        }

        private void cashier_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ στο Ταμείο, μπορείτε να επιλέξετε κάποιο ρόφημα ή σνακ για να αγοράσετε.");
        }

        private void tv_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ στην τηλεόραση, μπορείτε να την ενεργοποιήσετε/απενεργοποιήσετε.");
        }

        private void wc_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ εδώ, μεταφέρεστε στο WC.");
        }

        private void toExercise2_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ εδώ, μεταφέρεστε στον Χώρο Εκγύμνασης.");
        }

        private void toPool2_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ εδώ, μεταφέρεστε στην Πισίνα.");
        }

        private void toLockers2_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ εδώ, μεταφέρεστε στα Αποδυτήρια.");
        }

        private void exithelpbtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
