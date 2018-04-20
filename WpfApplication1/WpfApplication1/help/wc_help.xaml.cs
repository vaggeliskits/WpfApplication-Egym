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
    /// Interaction logic for wc_help.xaml
    /// </summary>
    public partial class wc_help : Page
    {
        public wc_help()
        {
            InitializeComponent();
        }

        private void toilet_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ στην τουαλέτα, απολαμβάνετε μια στιγμή ανακούφισης!");
        }

        private void wash1_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ στον νιπτήρα, μπορείτε να πλύνετε τα χέρια σας και να φρεσκαριστείτε.");
        }

        private void wash2_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ στον νιπτήρα, μπορείτε να πλύνετε τα χέρια σας και να φρεσκαριστείτε.");
        }

        private void wash3_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ στον νιπτήρα, μπορείτε να πλύνετε τα χέρια σας και να φρεσκαριστείτε.");
        }

        private void exit_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ εδώ, επιστρέφετε στο Μπαρ.");
        }

        private void exithelpbtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
