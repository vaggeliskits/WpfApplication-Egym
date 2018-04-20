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
    /// Interaction logic for exercise_help.xaml
    /// </summary>
    public partial class exercise_help : Page
    {
        public exercise_help()
        {
            InitializeComponent();
        }

        private void exithelpbtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void leg_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Kάνοντας κλικ σε αυτό το όργανο, ενεργοποιείται ένα παράθυρο στο οποίο εισάγετε τον αριθμό επαναλήψεων που επιθυμείτε και έπειτα κάνετε κλικ στο κουμπί 'OK' για να ξεκινήσετε να γυμνάζεστε.");
        }

        private void shoulderpress_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Kάνοντας κλικ σε αυτό το όργανο, ενεργοποιείται ένα παράθυρο στο οποίο εισάγετε τον αριθμό επαναλήψεων που επιθυμείτε και έπειτα κάνετε κλικ στο κουμπί 'OK' για να ξεκινήσετε να γυμνάζεστε.");
        }

        private void pulley_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Kάνοντας κλικ σε αυτό το όργανο, ενεργοποιείται ένα παράθυρο στο οποίο εισάγετε τον αριθμό επαναλήψεων που επιθυμείτε και έπειτα κάνετε κλικ στο κουμπί 'OK' για να ξεκινήσετε να γυμνάζεστε.");
        }

        private void weigths_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Kάνοντας κλικ στα Ελεύθερα Βάρη, ενεργοποιείται ένα παράθυρο στο οποίο εισάγετε τον αριθμό επαναλήψεων που επιθυμείτε και έπειτα κάνετε κλικ στο κουμπί 'OK' για να ξεκινήσετε να γυμνάζεστε.");
        }

        private void balls_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Kάνοντας κλικ στις Μπάλες Εκγύμνασης, ενεργοποιείται ένα παράθυρο στο οποίο εισάγετε τον αριθμό επαναλήψεων που επιθυμείτε και έπειτα κάνετε κλικ στο κουμπί 'OK' για να ξεκινήσετε να γυμνάζεστε.");
        }

        private void diadromos_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Kάνοντας κλικ σε αυτό το όργανο, ενεργοποιείται ένα παράθυρο στο οποίο εισάγετε το βάρος και το ύψος σας (σε δεκαδική μορφή).\nΒάσει των στοιχείων σας, υπολογίζεται το πρόγραμμα γυμναστικής σας.\nΤέλος, κάνοντας κλικ στο κουμπί 'Έναρξη', ξεκινάτε να γυμνάζεστε.\nΣτην περίπτωση που κουραστήκατε, μπορείτε να κάνετε κλικ στο κουμπί 'Τέλος'.");
        }

        private void podilato_hbtn1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Kάνοντας κλικ σε αυτό το όργανο, ενεργοποιείται ένα παράθυρο στο οποίο εισάγετε το βάρος και το ύψος σας (σε δεκαδική μορφή).\nΒάσει των στοιχείων σας, υπολογίζεται το πρόγραμμα γυμναστικής σας.\nΤέλος, κάνοντας κλικ στο κουμπί 'Έναρξη', ξεκινάτε να γυμνάζεστε.\nΣτην περίπτωση που κουραστήκατε, μπορείτε να κάνετε κλικ στο κουμπί 'Τέλος'.");
        }

        private void podilato_hbtn2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Kάνοντας κλικ σε αυτό το όργανο, ενεργοποιείται ένα παράθυρο στο οποίο εισάγετε το βάρος και το ύψος σας (σε δεκαδική μορφή).\nΒάσει των στοιχείων σας, υπολογίζεται το πρόγραμμα γυμναστικής σας.\nΤέλος, κάνοντας κλικ στο κουμπί 'Έναρξη', ξεκινάτε να γυμνάζεστε.\nΣτην περίπτωση που κουραστήκατε, μπορείτε να κάνετε κλικ στο κουμπί 'Τέλος'.");
        }

        private void elleiptiko_hbtn1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Kάνοντας κλικ σε αυτό το όργανο, ενεργοποιείται ένα παράθυρο στο οποίο εισάγετε το βάρος και το ύψος σας (σε δεκαδική μορφή).\nΒάσει των στοιχείων σας, υπολογίζεται το πρόγραμμα γυμναστικής σας.\nΤέλος, κάνοντας κλικ στο κουμπί 'Έναρξη', ξεκινάτε να γυμνάζεστε.\nΣτην περίπτωση που κουραστήκατε, μπορείτε να κάνετε κλικ στο κουμπί 'Τέλος'.");
        }

        private void elleiptiko_hbtn2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Kάνοντας κλικ σε αυτό το όργανο, ενεργοποιείται ένα παράθυρο στο οποίο εισάγετε το βάρος και το ύψος σας (σε δεκαδική μορφή).\nΒάσει των στοιχείων σας, υπολογίζεται το πρόγραμμα γυμναστικής σας.\nΤέλος, κάνοντας κλικ στο κουμπί 'Έναρξη', ξεκινάτε να γυμνάζεστε.\nΣτην περίπτωση που κουραστήκατε, μπορείτε να κάνετε κλικ στο κουμπί 'Τέλος'.");
        }

        private void trainer_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ στον γυμναστή, εμφανίζεται μια λίστα επιλογών εξυπηρέτησης (π.χ. ρύθμιση φωτισμού κ.λπ.).");
        }

        private void toPool_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ εδώ, μεταφέρεστε στην Πισίνα.");
        }

        private void toBar_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ εδώ, μεταφέρεστε στο Μπαρ.");
        }

        private void toLockers_hbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Κάνοντας κλικ εδώ, μεταφέρεστε στα Αποδυτήρια.");
        }
    }
}
