using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Hardcodet.Wpf.TaskbarNotification;
using UiPathEJC.Components.Services;
using UiPathEJC.Components.Settings;
using UiPathEJC.Service.Rest.Model;
using UiPathEJC.UserInterfaces.Windows;
using Configuration = UiPathEJC.Service.Rest.Client.Configuration;

namespace UiPathEJC
{
    /// <inheritdoc />
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        public static readonly string AuthorizationPrefix = "Bearer ";

        public static TaskbarIcon TaskbarIcon;

        async void OnAppStartUp(object sender, StartupEventArgs e)
        {
            await ApplyCulture();

            await Initialize(true);


            TaskbarIcon = FindResource("TrayIcon") as TaskbarIcon;
        }

        private async Task ApplyCulture()
        {
            var settings = new ApplicationSettings();
            CultureInfo ci;

            try
            {
                ci = new CultureInfo(settings.Culture);


                Thread.CurrentThread.CurrentCulture = ci;
                Thread.CurrentThread.CurrentUICulture = ci;
            }
            catch (Exception)
            {
                ci = new CultureInfo("de-DE");
            }
        }

        public async Task Initialize(bool TestMode)
        {
            new LoginWindow().Show();
            
                
        }

        public async Task Initialize()
        {
            try
            {
                var settings = new ApplicationSettings();

                var config = new Configuration {BasePath = settings.OrchestratorInstance};
                var auth = new AuthorizationService(config, AuthorizationPrefix);


                bool isLoggedIn = false;

                if (!string.IsNullOrWhiteSpace(settings.LastBearerToken))
                {
                    isLoggedIn = await auth.CanBearerTokenUsed(settings.LastBearerToken);
                }


                if (settings.AutoLogin)
                {
                    if (isLoggedIn)
                    {
                        await auth.UseBearerToken(settings.LastBearerToken);
                    }
                    else if (!string.IsNullOrWhiteSpace(settings.Tenant) &&
                             !string.IsNullOrWhiteSpace(settings.UserName) &&
                             !string.IsNullOrWhiteSpace(settings.Password))
                    {
                        await auth.Authorization(new LoginModel(
                            settings.Tenant,
                            settings.UserName,
                            settings.Password
                        ));

                        settings.LastBearerToken = auth.CurrentBearerToken;
                        settings.Save();
                    }

                    var authenticated = await auth.StillAuthenticated();
                    if (authenticated)
                    {
                        await StartMainWindow(auth);
                    }
                    else
                    {
                        await StartLoginWindow();
                    }
                }
                else
                {
                    await StartLoginWindow();
                }
            }
            catch (Exception e)
            {
                await StartLoginWindow();
            }
        }

        public static async Task StartLoginWindow()
        {
                var loginWindow = new LoginWindow();
                loginWindow.Show();
        }

        public static async Task StartMainWindow(AuthorizationService authorizationService)
        {
            var mainWindow = new MainWindow(authorizationService);
            mainWindow.Show();
        }
    }
}
