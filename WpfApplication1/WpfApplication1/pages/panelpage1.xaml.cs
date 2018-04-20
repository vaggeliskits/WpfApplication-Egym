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
using WpfApplication1.pages;


namespace WpfApplication1.pages
{
    /// <summary>
    /// Interaction logic for panelpage1.xaml
    /// </summary>
    public partial class panelpage1 : Page
    {
        public panelpage1()
        {
            InitializeComponent();
        }

        int duration;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double weight = Double.Parse(weighttxtbox.Text);
                double height = Double.Parse(heighttxtbox.Text);

                

                if ((weight == 000.00) ||(height == 0.00))      //checking if user has not inserted wight & height
                {
                    MessageBox.Show("Μη έγκυρα στοιχεία. Εισαγάγετε ξανά.");
                }
                else if (weight >= 45.00 && weight < 70.00 && height < 1.75)    //start checking workout duration
                {
                    duration = 7;
                    MessageBox.Show("Βάσει των στοιχείων σου, θα πρέπει να αθληθείς για " + duration + " λεπτά.");
                    this.NavigationService.Navigate(new panelpage2(duration));
                }
                else if (weight >= 45.00 && weight < 70.00 && height >= 1.75)
                {
                    duration = 5;
                    MessageBox.Show("Βάσει των στοιχείων σου, θα πρέπει να αθληθείς για " + duration + " λεπτά.");
                    this.NavigationService.Navigate(new panelpage2(duration));
                }
                else if (weight >= 70.00 && weight < 100.00 && height < 1.75)
                {
                    duration = 10;
                    MessageBox.Show("Βάσει των στοιχείων σου, θα πρέπει να αθληθείς για " + duration + " λεπτά.");
                    this.NavigationService.Navigate(new panelpage2(duration));
                }
                else if (weight >= 70.00 && weight < 100.00 && height >= 1.75)
                {
                    duration = 9;
                    MessageBox.Show("Βάσει των στοιχείων σου, θα πρέπει να αθληθείς για " + duration + " λεπτά.");
                    this.NavigationService.Navigate(new panelpage2(duration));
                }
                else if (weight >= 100.00 && height < 1.75)
                {
                    duration = 20;
                    MessageBox.Show("Βάσει των στοιχείων σου, θα πρέπει να αθληθείς για " + duration + " λεπτά.");
                    this.NavigationService.Navigate(new panelpage2(duration));
                }
                else if (weight >= 100.00 && height >= 1.75)
                {
                    duration = 15;
                    MessageBox.Show("Βάσει των στοιχείων σου, θα πρέπει να αθληθείς για " + duration + " λεπτά.");
                    this.NavigationService.Navigate(new panelpage2(duration));
                }
                else
                {
                    duration = 4;
                    MessageBox.Show("Βάσει των στοιχείων σου, θα πρέπει να αθληθείς για " + duration + " λεπτά.");
                    this.NavigationService.Navigate(new panelpage2(duration));  //passing duration variable to next page
                }
                // end of checking
            }
            catch (FormatException)
            {
                MessageBox.Show("Μη έγκυρα στοιχεία. Εισαγάγετε ξανά.");
            }
            
        }

        //clearing default textbox content when selected
        private void weighttxtbox_GotFocus(object sender, RoutedEventArgs e)
        {
            weighttxtbox.Text = string.Empty;
        }

        //clearing default textbox content when selected
        private void heighttxtbox_GotFocus(object sender, RoutedEventArgs e)
        {
            heighttxtbox.Text = string.Empty;
        }
    }
}
