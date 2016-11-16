namespace App.Services
{
    using Contracts;
    using Contracts.Data;
    using Data.Contracts;
    using Data.Repositories;

    public class GeoManager: IGeoService
    {
        private readonly IZipCodeDataAccess _zipRepository;

        public GeoManager()
        {
            
        }

        public GeoManager(IZipCodeDataAccess zipRepository)
        {
            _zipRepository = zipRepository;
        }

        public ZipCodeData GetZipInfo(string zipCode)
        {

            return new ZipCodeData { City = "Warsaw", State = "State", ZipCode = zipCode};
        }

        public string[] GetStates(bool primaryOnly)
        {
            return new[] {"demo"};
        }

        public ZipCodeData[] GetZips(string state)
        {
            return new[] {new ZipCodeData {City = "Demo", State = "Demo", ZipCode = "Zip code"}};
        }

        public ZipCodeData[] GetZips(string zip, int range)
        {
            return new[] { new ZipCodeData { City = "Demo 2", State = "Demo 2", ZipCode = "Zip code 2" } };
        }
    }
}
