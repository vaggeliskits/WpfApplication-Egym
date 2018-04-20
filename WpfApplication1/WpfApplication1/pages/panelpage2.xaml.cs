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
using System.Windows.Threading;

namespace WpfApplication1.pages
{
    /// <summary>
    /// Interaction logic for panelpage2.xaml
    /// </summary>

    public partial class panelpage2 : Page
    {
        DispatcherTimer timer = new DispatcherTimer();      //timer to calculate time elapsed
        DispatcherTimer timer2 = new DispatcherTimer();      //timer to calculate distance covered
        DispatcherTimer breathtimer = new DispatcherTimer();

        MediaPlayer breathsound = new MediaPlayer();

        public panelpage2(int duration)     //passing duration variable from previous page
        {
            InitializeComponent();
            this.duration = duration;       //passing duration variable from previous page
            
            timer.Tick += new EventHandler(timer_tick);
            timer.Interval = new TimeSpan(0, 0, 0, 1);     //interval is 100ms instead of 1s for demonstrating reasons
            timer.Start();

            timer2.Tick += new EventHandler(timer_tick2);
            timer2.Interval = new TimeSpan(0, 0, 0, 0, 500);     //interval is 50ms instead of 0.5s for demonstrating reasons
            timer2.Start();

            breathtimer.Tick += new EventHandler(breathtimer_tick);
            breathtimer.Interval = new TimeSpan(0, 0, 0, 4);     //interval is 50ms instead of 0.5s for demonstrating reasons
            breathtimer.Start();
        }

        int count = 0;      //time counter
        int count2 = 0;     //distance counter
        int minutes;
        int seconds;
        private int duration;

        public void breathtimer_tick(object sender, EventArgs e)
        {
            breathsound.Open(new Uri("../../sounds/heavybreathing.wav", UriKind.Relative));
            breathsound.Play();
            if (minutes == duration)
            {
                breathsound.Stop();
                breathtimer.Stop();
            }
        }

        public void timer_tick(object sender, EventArgs e)      //method displaying time elapsed
        {
           count++;
            minutes = count / 60;
            seconds = count % 60;

            if ((seconds < 10) && (minutes < 1))
            {
                timebox.Content = "00 : 0" + seconds.ToString();
            }
            else if ((seconds >= 10) && (seconds < 60) && (minutes < 1))
            {
                timebox.Content = "00 : " + seconds.ToString();
            }
            else if ((seconds < 10) && (minutes >= 1) && (minutes < 10))
            {
                timebox.Content = "0" + minutes.ToString() + " : 0" + seconds.ToString();
            }
            else if ((minutes >= 1) && (minutes < 10) && (seconds >= 10))
            {
                timebox.Content = "0" + minutes.ToString() + " : " + seconds.ToString();
            }
            else if ((minutes >= 10) && (seconds < 10))
            {
                timebox.Content = minutes.ToString() + " : 0" + seconds.ToString();
            }
            else
            {
                timebox.Content = minutes.ToString() + " : " + seconds.ToString();
            }

            if(minutes == duration)     //testing if duration reached and closing panelwindow
            {
                timer.Stop();
                MessageBox.Show("Επιτέλους!");
                Application.Current.Windows[1].Close();
            }
        }

        public void timer_tick2(object sender, EventArgs e)     //method displaying distance covered
        {
            count2++;
            if(count2 < 10)
            {
                distancebox.Content = "000" + count2;
            }
            else if((count2 >= 10) && (count2 < 100))
            {
                distancebox.Content = "00" + count2;
            }
            else if(count2 >=100)
            {
                distancebox.Content = "0" + count2;
            }
            else if ((count2 >= 1000) && (count2 < 1000))
            {
                distancebox.Content = count2;
            }

            if (minutes == duration)     //testing if duration reached and closing panelwindow
            {
                timer2.Stop();
            }
        }

        private void stopbtn_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            timer2.Stop();
            breathtimer.Stop();
            breathsound.Stop();
            MessageBox.Show("Πω πω, τα έχω παίξει...");
            Application.Current.Windows[1].Close();
        }
    }
}
