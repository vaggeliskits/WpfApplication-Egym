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
    /// Interaction logic for wc.xaml
    /// </summary>
    public partial class wc : Page
    {
        DispatcherTimer toilettimer = new DispatcherTimer();
        DispatcherTimer washtimer = new DispatcherTimer();

        MediaPlayer handswashsound = new MediaPlayer();
        MediaPlayer closedoorsound = new MediaPlayer();
        MediaPlayer peesound = new MediaPlayer();
        MediaPlayer flushsound = new MediaPlayer();

        public wc()
        {
            InitializeComponent();
            toilettimer.Tick += new EventHandler(toilettimer_tick);
            toilettimer.Interval = new TimeSpan(0, 0, 1);
            washtimer.Tick += new EventHandler(washtimer_tick);
            washtimer.Interval = new TimeSpan(0, 0, 1);
        }

        public void toilettimer_tick(object sender, EventArgs e)
        {
            toiletpb.Value++;

            if (toiletpb.Value == toiletpb.Maximum)
            {
                flushsound.Open(new Uri("../../sounds/flush.wav", UriKind.Relative));
                flushsound.Play();

                MessageBox.Show("Ξαλάφρωσα...");
                toiletpb.Visibility = Visibility.Hidden;
                door.Visibility = Visibility.Hidden;
                toilettimer.Stop();
            }
        }

        public void washtimer_tick(object sender, EventArgs e)
        {
            washpb.Value++;

            if (washpb.Value == washpb.Maximum)
            {
                MessageBox.Show("Χέρια καθαρά!");
                washpb.Visibility = Visibility.Hidden;
                washtimer.Stop();
            }
        }

        private void toiletbtn_Click(object sender, RoutedEventArgs e)
        {
            closedoorsound.Open(new Uri("../../sounds/door.wav", UriKind.Relative));
            closedoorsound.Play();
            peesound.Open(new Uri("../../sounds/pee.wav", UriKind.Relative));
            peesound.Play();

            door.Visibility = Visibility.Visible;
            toiletpb.Value = 0;
            toiletpb.Maximum = 5;
            toiletpb.Visibility = Visibility.Visible;
            toilettimer.Start();
        }

        private void wash1btn_Click(object sender, RoutedEventArgs e)
        {
            handswashsound.Open(new Uri("../../sounds/handswash.wav", UriKind.Relative));
            handswashsound.Play();

            washpb.Value = 0;
            washpb.Maximum = 5;
            washpb.Visibility = Visibility.Visible;
            washtimer.Start();
        }

        private void wash2btn_Click(object sender, RoutedEventArgs e)
        {
            handswashsound.Open(new Uri("../../sounds/handswash.wav", UriKind.Relative));
            handswashsound.Play();

            washpb.Value = 0;
            washpb.Maximum = 5;
            washpb.Visibility = Visibility.Visible;
            washtimer.Start();
        }

        private void wash3btn_Click(object sender, RoutedEventArgs e)
        {
            handswashsound.Open(new Uri("../../sounds/handswash.wav", UriKind.Relative));
            handswashsound.Play();

            washpb.Value = 0;
            washpb.Maximum = 5;
            washpb.Visibility = Visibility.Visible;
            washtimer.Start();
        }

        private void exitbtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

    }
}
