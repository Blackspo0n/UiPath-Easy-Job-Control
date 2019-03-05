using System;
using System.Security;
using System.Threading.Tasks;
using System.Windows;
using MaterialDesignThemes.Wpf;
using UiPathEJC.Components.Helper;
using UiPathEJC.Components.Services;
using UiPathEJC.Components.Settings;
using UiPathEJC.Service.Rest.Client;
using UiPathEJC.Service.Rest.Model;
using UiPathEJC.UserInterfaces.Base;
using UiPathEJC.UserInterfaces.UserControls;

namespace UiPathEJC.UserInterfaces.Windows.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        #region Binding Properties
        private string _tenantName;
        public string TenantName
        {
            get => _tenantName;
            set
            {
                if (value == _tenantName) return;

                _tenantName = value;
                OnPropertyChanged();
            }
        }

        private string _userName;
        public string UserName
        {
            get => _userName;
            set
            {
                if (value == _userName) return;

                _userName = value;
                OnPropertyChanged();
            }
        }
        private string _orchestratorInstance;
        public string OrchestratorInstance
        {
            get => _orchestratorInstance;
            set
            {
                if (value == _orchestratorInstance) return;

                _orchestratorInstance = value;
                OnPropertyChanged();
            }
        }

        private bool _autoLogin;
        public bool AutoLogin
        {
            get => _autoLogin;
            set
            {
                if (value == _autoLogin) return;

                _autoLogin = value;
                OnPropertyChanged();
            }
        }

        private bool _isDialogOpen;
        public bool IsDialogOpen
        {
            get => _isDialogOpen;
            set
            {
                if (value == _isDialogOpen) return;

                _isDialogOpen = value;
                OnPropertyChanged();

            }
        }

        private object _dialogContent;

        public object DialogContent
        {
            get => _dialogContent;
            set
            {
                if (value == _dialogContent) return;

                _dialogContent = value;
                OnPropertyChanged();
            }
        }


        #endregion

        #region Propierties
        public SecureString PasswordSecureString;

        private AuthorizationService _authorizationService;
        #endregion

        #region Commands
        public AsyncCommand<object> LoginCommand{ get; private set; }
        public AsyncCommand<object> ClosingDialogCommand { get; private set; }
        #endregion

        public event Action RequestClose;

        public LoginViewModel()
        {
            LoginCommand = AsyncCommandEx.Create((url, token) => AuthorizationCommand());
            ClosingDialogCommand = AsyncCommandEx.Create((o, token) => CloseDialogCommandCallback());
            PasswordSecureString = new SecureString();

            var settings = new ApplicationSettings();

            _tenantName = settings.Tenant;
            _autoLogin = settings.AutoLogin;
            _userName = settings.UserName;
            _orchestratorInstance = settings.OrchestratorInstance;
            IsDialogOpen = false;


        }

        private async Task CloseDialogCommandCallback()
        {
            IsDialogOpen = false;
            DialogContent = null;
        }

        public virtual async Task Close()
        {
            RequestClose?.Invoke();
        }

        public async Task AuthorizationCommand()
        {
            DialogContent = new WaitingDialog();
            IsDialogOpen = true;
            await Task.Delay(5000);


            try
            {
                var config = new Configuration()
                {
                    BasePath = OrchestratorInstance
                };

                _authorizationService = new AuthorizationService(config, App.AuthorizationPrefix);

                
                var success = await _authorizationService.Authorization(new LoginModel(TenantName, UserName,
                        StringHelper.SecureStringToString(PasswordSecureString)));
                
                if (success)
                {
                    var settings = new ApplicationSettings();
                    settings.OrchestratorInstance = OrchestratorInstance;
                    settings.Tenant = TenantName;
                    settings.UserName = UserName;
                    settings.Password = StringHelper.SecureStringToString(PasswordSecureString);
                    settings.AutoLogin = AutoLogin;
                    settings.LastBearerToken = _authorizationService.CurrentBearerToken;
                    settings.Save();
                    
                    await App.StartMainWindow(_authorizationService);
                    await Close();
                }
                else
                {
                    DialogContent = new TextDialog("Der Login war nicht erfolgreich. Bitte überprüfe deine Anmeldedaten.");
                }
            }
            catch (Exception e)
            {
                DialogContent = new TextDialog("Überprüfen Sie den Orchestrator URL." + e.Message);
            }

            
            return;
        }
    }
}
