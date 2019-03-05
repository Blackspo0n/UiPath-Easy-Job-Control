using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MaterialDesignExtensions.Model;
using MaterialDesignThemes.Wpf;
using UiPathEJC.Components.Services;
using UiPathEJC.Service.Rest.Api;
using UiPathEJC.UserInterfaces.Base;
using UiPathEJC.UserInterfaces.Interface;
using UiPathEJC.UserInterfaces.UserControls;
using UiPathEJC.UserInterfaces.UserControls.ViewModels;

namespace UiPathEJC.UserInterfaces.Views.ViewModels
{
    class UiPathProcessViewModel : ViewModelBase, IContentViewModel , INavigationItem
    {
        #region Navigation Binding Properties
        
        public string ViewName => "UiPath Prozesse";
        public string ShortName => "Prozesse";
        public object IconSource => PackIconKind.Server;
        private bool _isDialogOpen;

        public bool IsDialogOpen
        {
            get => _isDialogOpen;
            set
            {
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
                _dialogContent = value;
                OnPropertyChanged();
            }
        }

        private bool _isSelectable;

        public bool IsSelectable
        {
            get => _isSelectable;
            set
            {
                if (value.Equals(_isSelectable)) return;

                _isSelectable = value;
                OnPropertyChanged();

            }

        }
        private bool _isSelected;

        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                if (value.Equals(_isSelected)) return;

                _isSelected = value;
                OnPropertyChanged();
            }

        }
        
        public NavigationItemSelectedCallback NavigationItemSelectedCallback { get; set; }
        #endregion

        #region Datagrid Binding Properties

        private int _processCountWithoutTop;

        public int ProcessCountWithoutTop
        {
            get => _processCountWithoutTop;
            set
            {
                if (value == _processCountWithoutTop) return;
                _processCountWithoutTop = value;
                OnPropertyChanged();
            }
        }

        private int _currentPage;

        public int CurrentPage
        {
            get => _currentPage;
            set
            {
                if (value == _currentPage) return;
                _currentPage = value;
                OnPropertyChanged();
            }
        }

        private bool _dataGridIsBusy;

        public bool DataGridIsBusy
        {
            get => _dataGridIsBusy;
            set
            {
                _dataGridIsBusy = value;
                OnPropertyChanged();
            }
        }
        #endregion

        private readonly AuthorizationService _authorizationService;

        #region Collections

        public ObservableCollection<ProcessItemViewModel> JobCollection { get; }
        #endregion

        #region Commands
        public AsyncCommand<object> JobStartCommand { get; private set; }
        public ICommand ListNavigateCommand { get; private set; }
        #endregion

        public UiPathProcessViewModel()
        {

            IsSelectable = true;
            JobCollection = new ObservableCollection<ProcessItemViewModel>();

            JobStartCommand = AsyncCommandEx.Create((o, token) => StartJobCallback(o));
            ListNavigateCommand = AsyncCommandEx.Create((o, token) => NavigateCommandCallback(o));
        }

        public UiPathProcessViewModel(AuthorizationService authorizationService) : this()
        {
            _authorizationService = authorizationService;
            ListNavigateCommand.Execute(new NavigationAction() {Page = 1, SelectedValueOfItems = 10});
        }
        #region Methods

        private async Task StartJobCallback(object parameter)
        {
            Debug.WriteLine(parameter.GetType());
            MessageBox.Show(((ProcessItemViewModel)parameter).Process.Key);
            var Process = new ProcessService(_authorizationService);
            await Process.StartProcess(((ProcessItemViewModel)parameter).Process);

        }

        public async Task GetProcesses(int selectedValueOfItems, int page)
        {
            var processApi = new ReleasesApi(_authorizationService.ServiceConfiguration);

            int? skipvalue = null;
            if (selectedValueOfItems * (page - 1) > 0)
            {
                skipvalue = selectedValueOfItems * (page - 1);
            }
            var processes = await processApi.ReleasesGetReleasesAsync(
                "Environment,CurrentVersion", null, null,
                "Name asc", selectedValueOfItems, skipvalue, null
                );
            ProcessCountWithoutTop = processes.OdataCount;
            CurrentPage = page;
            JobCollection.Clear();

            foreach (var process in processes.Value)
            {
                JobCollection.Add(new ProcessItemViewModel(process));
            }
        }

        public async Task NavigateCommandCallback(object parameter)
        {
            DataGridIsBusy = true;
            switch (parameter)
            {
                case null: // Wenn Parameter null ist, wird das DataGrid aktualisiert
                    await GetProcesses(ProcessCountWithoutTop, CurrentPage);
                    break;
                case NavigationAction action:
                    await GetProcesses(action.SelectedValueOfItems, action.Page);
                    break;
            }

            DataGridIsBusy = false;
        }

        #endregion
    }
}