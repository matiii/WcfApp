namespace App.ConsoleHost
{
    using System;
    using System.ServiceModel;
    using Services;

    class Program
    {
        static void Main()
        {
            var host = new ServiceHost(typeof(GeoManager));
            new Configuration(host).Configure();
            host.Open();

            Console.WriteLine("Host has runned. Click enter to exit.");
            Console.ReadLine();
            host.Close();
        }
    }
}
