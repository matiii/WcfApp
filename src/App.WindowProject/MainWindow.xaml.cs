namespace App.WindowProject
{
    using System.Diagnostics;
    using System.ServiceModel;
    using System.Text;
    using System.Threading;
    using System.Windows;
    using Contracts.Data;
    using Proxies;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Title = $"Thread: {Thread.CurrentThread.ManagedThreadId} Process: {Process.GetCurrentProcess().Id}";
        }


        private void GetInfoBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var proxy = new GeoClient();

            ZipCodeData data = proxy.GetZipInfo("");

            GetInfoTextBlock.Text = $"{data.City} \r\n {data.State} \r\n {data.ZipCode}";

            proxy.Close();
        }

        private void GetZipCodesBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var address = new EndpointAddress("net.tcp://localhost:8009/GeoService");
            var binding = new NetTcpBinding();
            var proxy = new GeoClient(binding, address);

            ZipCodeData[] data = proxy.GetZips("");

            var sb = new StringBuilder();

            foreach (var zipCodeData in data)
                sb.AppendLine($"State: {zipCodeData.State} City: {zipCodeData.City} ZipCode: {zipCodeData.ZipCode}");

            GetZipsTextBLock.Text = sb.ToString();
            proxy.Close();
        }

        private void MakeCallBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var factory  = new ChannelFactory<IMessageService>("");
            IMessageService proxy = factory.CreateChannel();

            proxy.ShowMsg(MessageTextBox.Text);
            factory.Close();
        }
    }
}
