using System.Windows;

namespace ChessUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Show the Login Window as the first screen
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
        }
    }
}
