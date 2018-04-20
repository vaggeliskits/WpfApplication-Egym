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
    /// Interaction logic for reception2.xaml
    /// </summary>
    public partial class reception2 : Page
    {
        DispatcherTimer timerr2 = new DispatcherTimer();

        public reception2()
        {
            InitializeComponent();
            timerr2.Tick += new EventHandler(timerr2_tick);
            timerr2.Interval = new TimeSpan(0, 0, 1);
            timerr2.Start();
        }
        
        int countr = 0;
        public void timerr2_tick(object sender, EventArgs e)
        {
            countr++;

            if (countr == 3)
            {
                lblr2.Content = "Πού θέλεις να πας;";
            }
            else if (countr == 7)
            {
                groupboxr2.Visibility = Visibility.Hidden;
            }
            else if (countr == 15)
            {
                lblr2.Content = "Δεν σε βλέπω και πολύ σίγουρο...";
                groupboxr2.Visibility = Visibility.Visible;
            }
            else if (countr == 20)
            {
                 groupboxr2.Visibility = Visibility.Hidden;
            }
        }

        private void gymbtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new exercise2());
        }

        private void poolbtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new pool2());
        }

        private void barbtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new bar2());
        }

        private void lockersbtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new lockers2());
        }
    }
}
