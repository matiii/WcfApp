namespace App.WindowHost
{
    using System;

    static class Bootstrap
    {

        [STAThread]
        static void Main()
        {
            var app = new AppBootstrap();
            var mainWindow = new MainWindow();
            app.Run(mainWindow);
        }
    }
}
