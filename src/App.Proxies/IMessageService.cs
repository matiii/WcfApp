namespace App.Proxies
{
    using System.ServiceModel;

    [ServiceContract(Namespace = "http://mywebsite.com/IMessageService")]
    public interface IMessageService
    {
        [OperationContract(Name = "ShowMessage")]
        void ShowMsg(string message);
    }
}
