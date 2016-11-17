namespace App.Proxies
{
    using System.ServiceModel;
    using System.ServiceModel.Channels;
    using Contracts;
    using Contracts.Data;

    public class GeoClient: ClientBase<IGeoService>, IGeoService
    {
        public GeoClient(): base("tcpEP")
        {
        }

        public GeoClient(string endpointName) : base(endpointName) { }

        public GeoClient(Binding binding, EndpointAddress address): base(binding, address) { }

        public ZipCodeData GetZipInfo(string zipCode)
        {
            return Channel.GetZipInfo(zipCode);
        }

        public string[] GetStates(bool primaryOnly)
        {
            return Channel.GetStates(primaryOnly);
        }

        public ZipCodeData[] GetZips(string state)
        {
            return Channel.GetZips(state);
        }

        public ZipCodeData[] GetZips(string zip, int range)
        {
            return Channel.GetZips(zip, range);
        }
    }
}
