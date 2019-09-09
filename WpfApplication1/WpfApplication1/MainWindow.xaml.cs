﻿using System;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double volHist; //remembering the volume for mute toggle   
        DispatcherTimer hide = new DispatcherTimer(); //time to hide the controll bar (global in order to be used in action listener)

        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (mePlayer.Source != null)
            {
                try {
                    if (mePlayer.Position.Milliseconds == mePlayer.NaturalDuration.TimeSpan.Milliseconds)
                        this.CloseAllWindows();
                } catch (Exception) {
                   
                }
               
            }
            
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            mePlayer.Play();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            mePlayer.Pause();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            mePlayer.Stop();
        }
        //Hover
        private void image1_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            image1.Source = new BitmapImage(new Uri("./skipBtn.png", UriKind.Relative));            

        }
        //Hover
        private void image1_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            image1.Source = new BitmapImage(new Uri("./skipBtnHover.png", UriKind.Relative));
            
        }
        //Click
        private void image1_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("image1_MouseDown");
            this.CloseAllWindows();
        }
        private void ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            volHist = e.NewValue;
            mePlayer.Volume = e.NewValue;
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {           
            mePlayer.Volume = 0;
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            mePlayer.Volume = volHist;
        }

        //close main
        private void CloseAllWindows()
        {
            for (int intCounter = App.Current.Windows.Count - 1; intCounter >= 0; intCounter--)
                App.Current.Windows[intCounter].Close();
        }

    }
}
