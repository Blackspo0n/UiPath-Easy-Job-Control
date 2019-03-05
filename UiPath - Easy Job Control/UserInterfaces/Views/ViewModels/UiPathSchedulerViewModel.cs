using MaterialDesignExtensions.Model;
using MaterialDesignThemes.Wpf;
using UiPathEJC.UserInterfaces.Base;
using UiPathEJC.UserInterfaces.Interface;

namespace UiPathEJC.UserInterfaces.Views.ViewModels
{
    class UiPathSchedulerViewModel : ViewModelBase, IContentViewModel , INavigationItem
    {
        #region Binding Properties
        
        public string ViewName => "UiPath Schedular - Aufgabenvevrwaltung";
        public string ShortName => "Schedular";
        public object IconSource => PackIconKind.Schedule;

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

        public UiPathSchedulerViewModel()
        {
            IsSelectable = true;
        }

        public NavigationItemSelectedCallback NavigationItemSelectedCallback { get; set; }

        #endregion
    }
}