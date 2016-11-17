namespace App.WindowHost.Private
{
    using System;

    public class MessageManager: IMessageService
    {
        public MessageManager()
        {
        }

        public void ShowMessage(string message)
        {
            MainWindow.Current.SetMessage(message);
        }
    }
}
