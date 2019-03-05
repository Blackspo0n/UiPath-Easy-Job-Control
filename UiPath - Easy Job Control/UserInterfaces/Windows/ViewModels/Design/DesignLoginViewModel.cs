using System;
using System.Security;
using System.Threading.Tasks;
using System.Windows;
using UiPathEJC.Components.Helper;
using UiPathEJC.Components.Services;
using UiPathEJC.Components.Settings;
using UiPathEJC.Service.Rest.Client;
using UiPathEJC.Service.Rest.Model;
using UiPathEJC.UserInterfaces.Base;

namespace UiPathEJC.UserInterfaces.Windows.ViewModels
{
    public class DesignLoginViewModel : LoginViewModel
    {
        
        public DesignLoginViewModel()
        {
            PasswordSecureString = new SecureString();
            
            TenantName = "Default";
            AutoLogin = true;
            UserName = "admin";
            OrchestratorInstance = "https://platform.uipath.com/";

        }
            
    }
}
