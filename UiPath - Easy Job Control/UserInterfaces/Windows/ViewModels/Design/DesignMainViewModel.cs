using System.Collections.Generic;
using System.Collections.ObjectModel;
using MaterialDesignExtensions.Model;
using MaterialDesignThemes.Wpf;
using UiPathEJC.Components.Services;
using UiPathEJC.Service.Rest.Client;

namespace UiPathEJC.UserInterfaces.Windows.ViewModels.Design
{
    public class DesignMainViewModel : MainViewModel
    {

        public DesignMainViewModel() : base(new AuthorizationService(Configuration.Default, App.AuthorizationPrefix))
        {
        }
    }
}