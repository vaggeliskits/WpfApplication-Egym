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
    /// Interaction logic for RepeatsWindow.xaml
    /// </summary>
    public partial class RepeatsWindow : Window
    {
        public RepeatsWindow()
        {
            InitializeComponent();
        }

        DispatcherTimer timer = new DispatcherTimer();

        MediaPlayer gruntsound = new MediaPlayer();

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                pb.Value = 0;
                pb.Maximum = Int32.Parse(txtbox.Text);

                timer.Tick += new EventHandler(timer_tick);
                timer.Interval = new TimeSpan(0, 0, 1);
                timer.Start();
            }
            catch (FormatException)
            {
                MessageBox.Show("Μη έγκυρα στοιχεία. Εισαγάγετε ξανά.");
            }
        }

        public void timer_tick(object sender, EventArgs e)
        {
            try
            {
                if (pb.Value < Int32.Parse(txtbox.Text))
                {
                    pb.Value++;
                    gruntsound.Open(new Uri("../../sounds/grunting.wav", UriKind.Relative));
                    gruntsound.Play();
                }
                else
                {
                    timer.Stop();
                    MessageBox.Show("Ουφ! Τις έβγαλα!");
                    this.Close();
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Μη έγκυρα στοιχεία. Εισαγάγετε ξανά.");
            }
            
        }
    }
}
