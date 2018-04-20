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
    /// Interaction logic for reception_help.xaml
    /// </summary>
    public partial class reception_help : Page
    {
        public reception_help()
        {
            InitializeComponent();
        }

        private void gym_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ εδώ, μεταφέρεστε στον Χώρο Εκγύμνασης.");
        }

        private void pool_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ εδώ, μεταφέρεστε στην Πισίνα.");
        }

        private void bar_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ εδώ, μεταφέρεστε στο Μπαρ.");
        }

        private void lockers_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ εδώ, μεταφέρεστε στα Αποδυτήρια.");
        }

        private void exithelpbtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
