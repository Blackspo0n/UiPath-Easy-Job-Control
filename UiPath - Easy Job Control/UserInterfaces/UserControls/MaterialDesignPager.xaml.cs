using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using UiPathEJC.UserInterfaces.Base;

namespace UiPathEJC.UserInterfaces.UserControls
{
    public class NavigationAction
    {
        public NavigationType NavigationType { get; set; }
        public int PageOffset { get; set; }
        public int Page { get; set; }
        public int SelectedValueOfItems { get; set; }
        
    }

    public enum NavigationType
    {
        NavigateBack,
        NavigateNext,
        LastPage,
        FirstPage,
        NumberOfItemsChanged
    }

    /// <summary>
    /// Interaktionslogik für MaterialDesignPager.xaml
    /// </summary>
    public partial class MaterialDesignPager : UserControl, INotifyPropertyChanged
    {
        private int _selectedValueOfItems { get; set; }

        public int SelectedValueOfItems
        {
            get => _selectedValueOfItems;
            set
            {
                if (value == _selectedValueOfItems) return;

                _selectedValueOfItems = value;
                OnPropertyChanged();
            }
        }

        
        public IList<int> ListOfSelectedValueOfItems => new List<int> {1,2,10,25,50,100};


        #region Binding Values
        public int ItemsCount
        {
            get => (int)GetValue(ItemsCountProperty);
            set => SetValue(ItemsCountProperty, value);
        }

        public static readonly DependencyProperty ItemsCountProperty
            = DependencyProperty.Register(
                nameof(ItemsCount),
                typeof(int),
                typeof(MaterialDesignPager),
                new PropertyMetadata(0, OnDpChanged)
            );

        public bool IsPagerUseable
        {
            get => (bool)GetValue(IsPagerUseableProperty);
            set => SetValue(IsPagerUseableProperty, value);
        }

        public static readonly DependencyProperty IsPagerUseableProperty
            = DependencyProperty.Register(
                nameof(IsPagerUseable),
                typeof(bool),
                typeof(MaterialDesignPager),
                new PropertyMetadata(true, OnDpChanged)
            );

        public int CurrentPage
        {
            get => (int)GetValue(CurrentPageProperty);
            set
            {
                SetValue(CurrentPageProperty, value);
                RefreshData();
            }
        }

        public static readonly DependencyProperty CurrentPageProperty
            = DependencyProperty.Register(
                nameof(CurrentPage),
                typeof(int),
                typeof(MaterialDesignPager),
                new PropertyMetadata(1,OnDpChanged));

        private static void OnDpChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((MaterialDesignPager)d).RefreshData();
        }

        public int Pages
        {
            get
            {
                if (ItemsCount == 0) return 1;
                if (ItemsCount < SelectedValueOfItems) return 1;

                return (int)Math.Ceiling((ItemsCount / (double)SelectedValueOfItems));
            }
        }

        #endregion

        #region Command

        private ICommand _navigateNextCommand;
        public ICommand NavigateNextCommand
        {
            get
            {
                return _navigateNextCommand ?? (_navigateNextCommand = new AsyncRelayCommand(
                           param =>
                           {
                               var navigationAction = new NavigationAction
                               {
                                   SelectedValueOfItems = SelectedValueOfItems,
                                   NavigationType = NavigationType.NavigateNext,
                                   Page = CurrentPage + 1,
                                   PageOffset = 1
                               };

                               return RaiseNavigationCommand(navigationAction);
                           }
                           , o => IsPagerUseable && CurrentPage < Pages));
            }
        }


        private ICommand _lastPageCommand;
        public ICommand LastPageCommand
        {
            get
            {
                return _lastPageCommand ?? (_lastPageCommand = new AsyncRelayCommand(
                           param =>
                           {
                               var navigationAction = new NavigationAction
                               {
                                   SelectedValueOfItems = SelectedValueOfItems,
                                   NavigationType = NavigationType.LastPage,
                                   Page = Pages,
                                   PageOffset = 0
                               };

                               return RaiseNavigationCommand(navigationAction);
                           }
                           , o => IsPagerUseable && CurrentPage < Pages));
            }
        }

        private ICommand _firstPageCommand;
        public ICommand FirstPageCommand
        {
            get
            {
                return _firstPageCommand ?? (_firstPageCommand = new AsyncRelayCommand(
                           param =>
                           {
                               var navigationAction = new NavigationAction
                               {
                                   SelectedValueOfItems = SelectedValueOfItems,
                                   NavigationType = NavigationType.FirstPage,
                                   Page = 1,
                                   PageOffset = 0
                               };

                               return RaiseNavigationCommand(navigationAction);
                           }
                           , o => IsPagerUseable && CurrentPage > 1));
            }
        }

        private ICommand _changeSelectedValueOfItemsCommand;
        public ICommand ChangeSelectedValueOfItemsCommand
        {
            get
            {
                return _changeSelectedValueOfItemsCommand ?? (_changeSelectedValueOfItemsCommand = new AsyncRelayCommand(
                           param =>
                           {
                               var navigationAction = new NavigationAction();
                               navigationAction.SelectedValueOfItems = SelectedValueOfItems;
                               navigationAction.NavigationType = NavigationType.NumberOfItemsChanged;
                               navigationAction.Page = 1;
                               navigationAction.PageOffset = 0;

                               RefreshData();

                               return RaiseNavigationCommand(navigationAction);
                           }
                           , o => IsPagerUseable && CurrentPage - 1 < Pages));
            }
        }


        private ICommand _navigateBackCommand;
        public ICommand NavigateBackCommand
        {
            get
            {
                return _navigateBackCommand ?? (_navigateBackCommand = new AsyncRelayCommand(
                           param =>
                           {
                               var navigationAction = new NavigationAction();
                               navigationAction.SelectedValueOfItems = SelectedValueOfItems;
                               navigationAction.NavigationType = NavigationType.NavigateBack;
                               navigationAction.Page = CurrentPage-1;
                               navigationAction.PageOffset = -1;

                               return RaiseNavigationCommand(navigationAction);
                           }
                           , o => IsPagerUseable && CurrentPage > 1));
            }
        }

#pragma warning disable 1998
        protected async Task RaiseNavigationCommand(object param)
#pragma warning restore 1998
        {
            Navigate?.Execute(param);
            
        }

        public ICommand Navigate
        {
            get => (ICommand)GetValue(NavigateCommandProperty);
            set => SetValue(NavigateCommandProperty, value);
        }

        public static readonly DependencyProperty NavigateCommandProperty
            = DependencyProperty.Register(
                nameof(Navigate),
                typeof(ICommand),
                typeof(MaterialDesignPager),
                new PropertyMetadata( new UIPropertyMetadata(null))
            );      

        #endregion


        public MaterialDesignPager()
        {
            InitializeComponent();
            SelectedValueOfItems = 10;
        }
        
        public void RefreshData()
        {
            OnPropertyChanged("Pages");
            OnPropertyChanged("ItemsCount");
            OnPropertyChanged("CurrentPage");
        }

        #region Dirty voilating DRY PC Implementation
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
