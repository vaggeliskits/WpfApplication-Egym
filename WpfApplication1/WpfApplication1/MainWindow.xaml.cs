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
using WpfApplication1.help;         //used for navigating to help pages in help folder
using WpfApplication1.pages;        //used for accessing pages in pages folder

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void restartbtn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void closebtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        
        private void helpbtn_Click(object sender, RoutedEventArgs e)
        {
            switch (myframe.Content.ToString())
            {
                case "WpfApplication1.pages.startpage":
                    myframe.NavigationService.Navigate(new startpage_help());
                    MessageBox.Show("Για περισσότερες, πληροφορίες μπορείτε να κάνετε κλικ στα κουμπιά 'Πελάτης' και 'Γυμναστής'.\n\nΓια να συνεχίσετε την περιήγησή σας στην εφαρμογή, κάντε κλικ στο κουμπί 'Έξοδος από Λειτουργία Βοήθειας'.");
                    break;
                case "WpfApplication1.pages.reception":
                    myframe.NavigationService.Navigate(new reception_help());
                    MessageBox.Show("Από τον χώρο υποδοχής, μπορείτε να μεταβείτε σε όποιον χώρο του γυμναστηρίου επιθυμείτε.\n\nΓια να συνεχίσετε την περιήγησή σας στην εφαρμογή, κάντε κλικ στο κουμπί 'Έξοδος από Λειτουργία Βοήθειας'.");
                    break;
                case "WpfApplication1.pages.exercise":
                    myframe.NavigationService.Navigate(new exercise_help());
                    MessageBox.Show("Ο Χώρος Εκγύμνασης περιλαμβάνει όργανα και μηχανήματα εκγύμνασης όπως:\n1) Διάδρομο\n2) Ποδήλατα\n3) Ελλειπτικά\n4) Τροχαλία Εκγύμνασης\n5) Πιέσεις Ώμων\n6) Εκτάσεις Ποδιών\n7) Μπάλες Εκγύμνασης\n8) Ελεύθερα Βάρη\nΓια περισσότερες πληροφορίες, κάντε κλικ σε κάθε ένα από αυτά.\nΕπίσης, μπορείτε με ένα κλικ να απευθυνθείτε και στον γυμναστή.\n\nΓια να συνεχίσετε την περιήγησή σας στην εφαρμογή, κάντε κλικ στο κουμπί 'Έξοδος από Λειτουργία Βοήθειας'.");
                    break;
                case "WpfApplication1.pages.pool":
                    myframe.NavigationService.Navigate(new pool_help());
                    MessageBox.Show("Στον χώρο της Πισίνας, μπορείτε να κάνετε κλικ στην πισίνα για να κολυμπήσετε, καθώς και να απευθείτε στον γυμναστή.\nΓια περισσότερες πληροφορίες, μπορείτε να κάνετε κλικ στο καθένα από αυτά.\n\nΓια να συνεχίσετε την περιήγησή σας στην εφαρμογή, κάντε κλικ στο κουμπί 'Έξοδος από Λειτουργία Βοήθειας'.");
                    break;
                case "WpfApplication1.pages.bar":
                    myframe.NavigationService.Navigate(new bar_help());
                    MessageBox.Show("Στον χώρο του Μπαρ, μπορείτε να καθίσετε, να χαλαρώσετε και να δείτε τηλεόραση, καθώς και να απευθυνθείτε στο Ταμείο.\nΕπίσης, από τον χώρο του Μπαρ μπορείτε να επισκεφθείτε το WC.\nΓια περισσότερες πληροφορίες, μπορείτε να κάνετε κλικ στο καθένα από αυτά.\n\nΓια να συνεχίσετε την περιήγησή σας στην εφαρμογή, κάντε κλικ στο κουμπί 'Έξοδος από Λειτουργία Βοήθειας'.");
                    break;
                case "WpfApplication1.pages.lockers":
                    myframe.NavigationService.Navigate(new lockers_help());
                    MessageBox.Show("Στα Αποδυτήρια, μπορείτε κάνετε κλικ στις ντουζιέρες για να κάνετε ένα ντουζ, καθώς και να απευθυνθείτε στον γυμναστή.\nΓια περισσότερες πληροφορίες, μπορείτε να κάνετε κλικ στο καθένα από αυτά.\n\nΓια να συνεχίσετε την περιήγησή σας στην εφαρμογή, κάντε κλικ στο κουμπί 'Έξοδος από Λειτουργία Βοήθειας'.");
                    break;
                case "WpfApplication1.pages.reception2":
                    myframe.NavigationService.Navigate(new reception_help());
                    MessageBox.Show("Από τον χώρο υποδοχής, μπορείτε να μεταβείτε σε όποιον χώρο του γυμναστηρίου επιθυμείτε.");
                    break;
                case "WpfApplication1.pages.exercise2":
                    myframe.NavigationService.Navigate(new exercise2_help());
                    MessageBox.Show("Στον χώρο εκγύμνασης, μπορείτε να κάνετε κάποιες ρυθμίσεις επί του χώρου.\nΕπίσης, θα συναντήσετε πελάτες, οι οποίοι πιθανώς θα ζητήσουν να τους εξυπηρετήσετε.\nΓια περισσότερες πληροφορίες, μπορείτε να κάνετε κλικ στα διάφορα κουμπιά.\n\nΓια να συνεχίσετε την περιήγησή σας στην εφαρμογή, κάντε κλικ στο κουμπί 'Έξοδος από Λειτουργία Βοήθειας'.");
                    break;
                case "WpfApplication1.pages.pool2":
                    myframe.NavigationService.Navigate(new pool2_help());
                    MessageBox.Show("Στην Πισίνα, μπορείτε να κάνετε κάποιες ρυθμίσεις επί του χώρου.\nΕπίσης, θα συναντήσετε πελάτες, οι οποίοι πιθανώς θα ζητήσουν να τους εξυπηρετήσετε.\nΓια περισσότερες πληροφορίες, μπορείτε να κάνετε κλικ στα διάφορα κουμπιά.\n\nΓια να συνεχίσετε την περιήγησή σας στην εφαρμογή, κάντε κλικ στο κουμπί 'Έξοδος από Λειτουργία Βοήθειας'.");
                    break;
                case "WpfApplication1.pages.bar2":
                    myframe.NavigationService.Navigate(new bar2_help());
                    MessageBox.Show("Στο Μπαρ, μπορείτε να ανοίξετε/κλείσετε την τηλεόραση, καθώς και να απευθυνθείτε στο Ταμείο για να αγοράσετε κάποιο ρόφημα ή σνακ.\nΕπίσης, από τον χώρο του Μπαρ μπορείτε να επισκεφθείτε το WC.\nΓια περισσότερες πληροφορίες, μπορείτε να κάνετε κλικ στα διάφορα κουμπιά.\n\nΓια να συνεχίσετε την περιήγησή σας στην εφαρμογή, κάντε κλικ στο κουμπί 'Έξοδος από Λειτουργία Βοήθειας'.");
                    break;
                case "WpfApplication1.pages.lockers2":
                    myframe.NavigationService.Navigate(new lockers2_help());
                    MessageBox.Show("Στα Αποδυτήρια, μπορείτε να κάνετε κάποιες ρυθμίσεις επί του χώρου.\nΕπίσης, θα συναντήσετε πελάτες, οι οποίοι πιθανώς θα ζητήσουν να τους εξυπηρετήσετε.\nΓια περισσότερες πληροφορίες, μπορείτε να κάνετε κλικ στα διάφορα κουμπιά.\n\nΓια να συνεχίσετε την περιήγησή σας στην εφαρμογή, κάντε κλικ στο κουμπί 'Έξοδος από Λειτουργία Βοήθειας'.");
                    break;
                case "WpfApplication1.pages.wc":
                    myframe.NavigationService.Navigate(new wc_help());
                    MessageBox.Show("Στο W.C. μπορείτε να φρεσκαριστείτε.\nΓια περισσότερες πληροφορίες, μπορείτε να κάνετε κλικ στα διάφορα κουμπιά.\n\nΓια να συνεχίσετε την περιήγησή σας στην εφαρμογή, κάντε κλικ στο κουμπί 'Έξοδος από Λειτουργία Βοήθειας'.");
                    break;
            }
        }
    }
}
