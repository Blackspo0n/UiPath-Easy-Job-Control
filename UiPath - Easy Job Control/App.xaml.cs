using System;
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
            await SetLanguageDictionary();

            await Initialize();


            TaskbarIcon = FindResource("TrayIcon") as TaskbarIcon;
        }

        private async Task SetLanguageDictionary()
        {
            ResourceDictionary dict = new ResourceDictionary();
            switch (Thread.CurrentThread.CurrentCulture.ToString())
            {
                default:
                    dict.Source = new Uri("..\\Resources\\Language\\StringResources.xaml", UriKind.Relative);
                    break;
            }
            Resources.MergedDictionaries.Add(dict);
        }

        public async Task Initialize(bool TestMode)
        {
            new FastStartTrayWindow().Show();
            
                
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
