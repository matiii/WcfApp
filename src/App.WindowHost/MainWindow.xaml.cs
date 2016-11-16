namespace App.WindowHost
{
    using System;
    using System.ServiceModel;
    using System.Threading;
    using System.Windows;
    using Services;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ServiceHost _geoHost;

        public MainWindow()
        {
            InitializeComponent();

            Title = $"Ui running on {Thread.CurrentThread.ManagedThreadId} thread.";

            StartBtn.IsEnabled = true;
            StopBtn.IsEnabled = false;
        }

        private void StartBtn_OnClick(object sender, RoutedEventArgs e)
        {
            _geoHost = new ServiceHost(typeof(GeoManager));
            _geoHost.Open();

            StartBtn.IsEnabled = false;
            StopBtn.IsEnabled = true;
        }

        private void StopBtn_OnClick(object sender, RoutedEventArgs e)
        {
            _geoHost.Close();

            StartBtn.IsEnabled = true;
            StopBtn.IsEnabled = false;
        }
    }
}
