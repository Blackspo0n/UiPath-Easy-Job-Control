using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MaterialDesignExtensions.Model;
using MaterialDesignThemes.Wpf;
using UiPathEJC.Components.Services;
using UiPathEJC.Components.Settings;
using UiPathEJC.Service.Rest.Api;
using UiPathEJC.UserInterfaces.Base;
using UiPathEJC.UserInterfaces.Interface;
using UiPathEJC.UserInterfaces.UserControls;
using UiPathEJC.UserInterfaces.UserControls.ViewModels;

namespace UiPathEJC.UserInterfaces.Views.ViewModels
{
    class FastStartViewModel : ViewModelBase, IContentViewModel , INavigationItem
    {
        #region Navigation Properties
        
        public string ViewName => "Fast start configurated Jobs";
        public string ShortName => "Fast Start";
        public object IconSource => PackIconKind.ViewDashboard;

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

        private AuthorizationService _authorizationService;

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

        #region Binding Properties


        public ObservableCollection<IJobSettings> JobCollection { get; }

        #endregion

        private IAsyncCommand _addCommand;
        public IAsyncCommand AddCommand
        {
            get
            {
                return _addCommand ?? (
                    _addCommand = AsyncCommandEx.Create((o, token) => AddFastStartJobTask(o))
                );
            }
        }

        public FastStartViewModel()
        {
            IsSelectable = true;
            JobCollection = new ObservableCollection<IJobSettings>();
            var test = JobsSettings.Load(JobsSettings.DefaultFilename);

            if (test.JobSettings == null) return;

            foreach (var fastStartEntry in test.JobSettings)
            {
                JobCollection.Add(fastStartEntry);
            }
        }

        public FastStartViewModel(AuthorizationService authorizationService) : this()
        {
            _authorizationService = authorizationService;
        }


        public async Task AddFastStartJobTask(object parameter)
        {
            IsDialogOpen = true;
            DialogContent = new JobConfigurationDialog();

            MessageBox.Show("Test");

            IsDialogOpen = false;
        }

    }
}