using MaterialDesignExtensions.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;
using UiPathEJC.Components.Services;
using UiPathEJC.UserInterfaces.Base;
using UiPathEJC.UserInterfaces.Interface;
using UiPathEJC.UserInterfaces.Views.ViewModels;

// ReSharper disable ExplicitCallerInfoArgument
// Need to call OnPropertyChanged from command to force the ContentPresenter to Update to the current view

namespace UiPathEJC.UserInterfaces.Windows.ViewModels
{
    public class MainViewModel : ViewModelBase
    {

        #region Binding Properties

        public INavigationItem CurrentContent
        {
            get
            {
                foreach (var item in NavigationItems)
                {
                    if (item.IsSelected) return item;
                }

                return null;

            }
        }

        #endregion

        #region Commands
        public AsyncCommand<object> ClosingCommand { get; }
        public ICommand ViewUpdatedCommand { get; }

        #endregion

        #region Services
        private readonly AuthorizationService _authorizationService;
        private readonly HeartbeatService _heartbeatService;

        #endregion

        #region Collections

        public ObservableCollection<INavigationItem> NavigationItems { get; set; }      

        #endregion

        public MainViewModel(AuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
            _heartbeatService = new HeartbeatService(_authorizationService);
            ClosingCommand = new AsyncCommand<object>(async (unused, token) => await _heartbeatService.Stop());
            ViewUpdatedCommand = new RelayCommand(o =>
            {
                OnPropertyChanged("CurrentContent");

            } , o => true);


            CreateNavigation();
        }
        


        private void CreateNavigation()
        {
            NavigationItems = new ObservableCollection<INavigationItem>()
            {
                new SubheaderNavigationItem() { Subheader = "Easy Job Control" },
                new FastStartViewModel(_authorizationService) {IsSelected = true},


                new SubheaderNavigationItem() { Subheader = "UiPath Orchestrator" },
                new UiPathProcessViewModel(_authorizationService),
                new UiPathSchedulerViewModel(),


                new SubheaderNavigationItem() { Subheader = "Sonstiges" },
                new SettingsViewModel()
            };

            OnPropertyChanged("NavigationItems");
            OnPropertyChanged("CurrentContent");
        }
    }
}