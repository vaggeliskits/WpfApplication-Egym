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
using System.Windows.Threading;

namespace WpfApplication1.pages
{
    
    /// <summary>
    /// Interaction logic for reception.xaml
    /// </summary>
    public partial class reception : Page
    {
        DispatcherTimer timerr = new DispatcherTimer();

        public reception()
        {
            InitializeComponent();
            timerr.Tick += new EventHandler(timerr_tick);
            timerr.Interval = new TimeSpan(0, 0, 1);
            timerr.Start();
        }
        
        int countr = 0;
        public void timerr_tick(object sender, EventArgs e)
        {
            countr++;
            
            if (countr == 3)
            {
                lblr.Content = "Ποιον χώρο μας\nθα θέλατε να επισκεφθείτε;";
            }
            else if (countr == 7)
            {
                groupboxr.Visibility = Visibility.Hidden;
            }
            else if (countr == 15)
            {
                lblr.Content = "Μου φαίνεστε κάπως\nαναποφάσιστος...";
                groupboxr.Visibility = Visibility.Visible;
            }
            else if (countr == 20)
            {
                 groupboxr.Visibility = Visibility.Hidden;
            }
        }

        private void gymbtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new exercise());
        }

        private void poolbtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new pool());
        }

        private void barbtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new bar());
        }

        private void lockersbtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new lockers());
        }
    }
}
