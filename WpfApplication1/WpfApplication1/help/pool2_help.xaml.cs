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
    /// Interaction logic for pool2_help.xaml
    /// </summary>
    public partial class pool2_help : Page
    {
        public pool2_help()
        {
            InitializeComponent();
        }

        private void pooltemp_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ στον Ρυθμιστή Θερμοκρασίας Νερού, μπορείτε να αυξομειώσετε τη θερμοκρασία του νερού της πισίνας.");
        }

        private void poollights_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Σύροντας τον διακόπτη, μπορείτε να δυναμώσετε/χαμηλώσετε τον φωτισμό.");
        }

        private void toExercise2_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ εδώ, μεταφέρεστε στον Χώρο Εκγύμνασης.");
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
