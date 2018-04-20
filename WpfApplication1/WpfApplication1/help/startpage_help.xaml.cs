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
    /// Interaction logic for startpage_help.xaml
    /// </summary>
    public partial class startpage_help : Page
    {
        public startpage_help()
        {
            InitializeComponent();
        }

        private void cstmer_h_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοτας κλικ στο κουμπί 'Πελάτης', εισέρχεστε στο Ηλεκτρονικό Γυμναστήριο ως πελάτης έχοντας λειτουργίες διαφόρων δραστηριοτήτων, εκτός άπό μερικές που είναι διαθέσιμες μόνο για έναν υπάλληλο (π.χ. ρύθμιση φωτισμού κ.λπ.).");
        }

        private void exithelpbtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void empl_h_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοτας κλικ στο κουμπί 'Γυμναστής', εισέρχεστε στο Ηλεκτρονικό Γυμναστήριο ως γυμναστής διαθέτοντας λειτουργίες υπαλλήλου με περαιτέρω δικαιώματα, καθώς και λειτουργίες εξυπηρέτησης πελατών.");
        }
    }


}
