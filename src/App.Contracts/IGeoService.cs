namespace App.Contracts
{
    using System.ServiceModel;
    using Data;

    [ServiceContract]
    public interface IGeoService
    {
        [OperationContract]
        ZipCodeData GetZipInfo(string zipCode);

        [OperationContract]
        string[] GetStates(bool primaryOnly);

        [OperationContract(Name = "GetZipsByState")]
        ZipCodeData[] GetZips(string state);

        [OperationContract(Name = "GetZipsForRange")]
        ZipCodeData[] GetZips(string zip, int range);
    }
}
