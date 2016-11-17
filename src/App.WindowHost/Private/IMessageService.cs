namespace App.WindowHost.Private
{
    using System.ServiceModel;

    [ServiceContract(Namespace = "http://mywebsite.com/IMessageService")]
    public interface IMessageService
    {
        [OperationContract]
        void ShowMessage(string message);
    }
}
