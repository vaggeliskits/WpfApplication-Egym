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
    /// Interaction logic for exercise2_help.xaml
    /// </summary>
    public partial class exercise2_help : Page
    {
        public exercise2_help()
        {
            InitializeComponent();
        }

        private void ac_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ στο air-condition, μπορείτε να ενεργοποιήσετε/απενεργοποιήσετε τον κλιματισμό.");
        }

        private void lights_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Σύροντας τον διακόπτη, μπορείτε να δυναμώσετε/χαμηλώσετε τον φωτισμό.");
        }

        private void toPool2_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ εδώ, μεταφέρεστε στην Πισίνα.");
        }

        private void toBar2_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ εδώ, μεταφέρεστε στο Μπαρ.");
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
