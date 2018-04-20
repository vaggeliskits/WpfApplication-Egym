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

namespace WpfApplication1.pages
{
    /// <summary>
    /// Interaction logic for startpage.xaml
    /// </summary>
    public partial class startpage : Page
    {
        public startpage()
        {
            InitializeComponent();
        }

        private void cstmer_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new reception());
        }

        private void empl_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new reception2());
        }

    }
}
