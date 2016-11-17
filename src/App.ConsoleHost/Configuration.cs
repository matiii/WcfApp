namespace App.ConsoleHost
{
    using System.ServiceModel;
    using Contracts;

    public class Configuration
    {
        private readonly ServiceHost _host;

        public Configuration(ServiceHost host)
        {
            _host = host;
        }

        public void Configure()
        {
            //string address = "net.tcp://localhost:8009/GeoService";
            //var binding = new NetTcpBinding();
            //var contract = typeof(IGeoService);

            //_host.AddServiceEndpoint(contract, binding, address);
        }
    }
}
