using System.Windows;
using System.Windows.Controls;
using MahApps.Metro.Controls;
using UiPathEJC.UserInterfaces.Windows.ViewModels;

namespace UiPathEJC.UserInterfaces.Windows
{
    /// <inheritdoc cref="Window" />
    /// <summary>
    /// Interaktionslogik für LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : MetroWindow
    {
        public LoginWindow()
        {
            this.DataContext = new LoginViewModel();
            InitializeComponent();

            ((LoginViewModel) this.DataContext).RequestClose += this.Close;

        }

        private void PasswordBox_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            ((LoginViewModel) DataContext).PasswordSecureString = ((PasswordBox) sender).SecurePassword;
        }
    }
}
