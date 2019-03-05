using System.Threading.Tasks;
using System.Windows;
using MaterialDesignExtensions.Controls;
using UiPathEJC.Components.Services;
using UiPathEJC.UserInterfaces.UserControls;
using UiPathEJC.UserInterfaces.Views;
using UiPathEJC.UserInterfaces.Views.ViewModels;
using UiPathEJC.UserInterfaces.Windows.ViewModels;

namespace UiPathEJC.UserInterfaces.Windows
{

    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow(AuthorizationService authorizationService)
        {
            InitializeComponent();
            DataContext = new MainViewModel(authorizationService);
        }

    }
}
