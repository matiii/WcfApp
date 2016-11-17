namespace App.WindowHost
{
    using System;
    using System.ServiceModel;
    using System.Threading;
    using System.Windows;
    using Private;
    using Services;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ServiceHost _geoHost;
        private ServiceHost _messageHost;

        public static MainWindow Current { get; private set; }

        public Action<string> SetMessage => str => MessageTextBlock.Text = $"Msg: {str} | ThreadId: {Thread.CurrentThread.ManagedThreadId}";

        public MainWindow()
        {
            InitializeComponent();

            Current = this;

            Title = $"Ui running on {Thread.CurrentThread.ManagedThreadId} thread.";

            StartBtn.IsEnabled = true;
            StopBtn.IsEnabled = false;
        }

        private void StartBtn_OnClick(object sender, RoutedEventArgs e)
        {
            _geoHost = new ServiceHost(typeof(GeoManager));
            _messageHost = new ServiceHost(typeof(MessageManager));

            _geoHost.Open();
            _messageHost.Open();

            StartBtn.IsEnabled = false;
            StopBtn.IsEnabled = true;
        }

        private void StopBtn_OnClick(object sender, RoutedEventArgs e)
        {
            _geoHost.Close();
            _messageHost.Close();

            StartBtn.IsEnabled = true;
            StopBtn.IsEnabled = false;
        }
    }
}
