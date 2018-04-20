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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for SwimmingWindow.xaml
    /// </summary>
    public partial class SwimmingWindow : Window
    {
        public SwimmingWindow()
        {
            InitializeComponent();
        }

        DispatcherTimer swimtimer = new DispatcherTimer();

        MediaPlayer swimsound = new MediaPlayer();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                swimpb.Value = 0;
                swimpb.Maximum = Int32.Parse(swimtxtbox.Text);
                swimtimer.Tick += new EventHandler(swimtimer_tick);
                swimtimer.Interval = new TimeSpan(0, 0, 0, 1, 250);
                swimtimer.Start();
            }
            catch(FormatException)
            {
                MessageBox.Show("Μη έγκυρα στοιχεία. Εισαγάγετε ξανά.");
            }
        }

        public void swimtimer_tick(object sender, EventArgs e)
        {
            try
            {
                if (swimpb.Value < Int32.Parse(swimtxtbox.Text))
                {
                    swimpb.Value++;
                    swimsound.Open(new Uri("../../sounds/swim.wav", UriKind.Relative));
                    swimsound.Play();
                }
                else
                {
                    swimtimer.Stop();
                    MessageBox.Show("Ουφ! Τα έβγαλα!");
                    this.Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Μη έγκυρα στοιχεία. Εισαγάγετε ξανά.");
            }
        }

    }
}
