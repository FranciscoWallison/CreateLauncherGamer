using System;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using System.Windows.Input;
using System.Collections.Generic;



namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double volHist; //remembering the volume for mute toggle   
        DispatcherTimer hide = new DispatcherTimer(); //time to hide the controll bar (global in order to be used in action listener)
        List<Employeedata> Employeedatalist = new List<Employeedata>();

        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

            Cursor cursor = new Cursor("C:/Users/wallison.nascimento/Documents/Visual Studio 2015/Projects/WpfApplication1/WpfApplication1/defaultRag.ani");
            mainWindow.Cursor = cursor;
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
            Cursor cursor = new Cursor("C:/Users/wallison.nascimento/Documents/Visual Studio 2015/Projects/WpfApplication1/WpfApplication1/defaultRag.ani");
            mainWindow.Cursor = cursor;
        }
        //Hover
        private void image1_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            image1.Source = new BitmapImage(new Uri("./skipBtnHover.png", UriKind.Relative));
            clickRagOff();
        }
        //Click
        private void image1_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {           
            clickRagOn();
            this.CloseAllWindows();
        }
        private void ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            clickRagOn();
            volHist = e.NewValue;
            mePlayer.Volume = e.NewValue;
            //clickRagOff();
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            clickRagOn();
            mePlayer.Volume = 0;
            //clickRagOff();
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            clickRagOn();
            mePlayer.Volume = volHist;
            //clickRagOff();
        }
  
        private void checkBox_MouseEnter(object sender, MouseEventArgs e)
        {
            clickRagOff();
        }

        private void checkBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            clickRagOn();
        }
        private void youTube_MouseDown(object sender, MouseButtonEventArgs e)
        {
            clickRagOn();
        }
        private void discord_MouseDown(object sender, MouseButtonEventArgs e)
        {
            clickRagOn();
        }       
        private void checkBox_MouseLeave(object sender, MouseEventArgs e)
        {
            Cursor cursor = new Cursor("C:/Users/wallison.nascimento/Documents/Visual Studio 2015/Projects/WpfApplication1/WpfApplication1/defaultRag.ani");
            mainWindow.Cursor = cursor;
        }

        private void clickRagOn() {
            Cursor cursor = new Cursor("C:/Users/wallison.nascimento/Documents/Visual Studio 2015/Projects/WpfApplication1/WpfApplication1/pressClickRag.ani");
            mainWindow.Cursor = cursor;
        }

        private void clickRagOff()
        {
            Cursor cursor = new Cursor("C:/Users/wallison.nascimento/Documents/Visual Studio 2015/Projects/WpfApplication1/WpfApplication1/pressRag.cur");
            mainWindow.Cursor = cursor;
        }

        //close main
        private void CloseAllWindows()
        {
            for (int intCounter = App.Current.Windows.Count - 1; intCounter >= 0; intCounter--)
                App.Current.Windows[intCounter].Close();
        }

        public class Employeedata
        {
            public int ID { get; set; }
            public string Photo { get; set; }
            public string Name { get; set; }
        }
    }
}
