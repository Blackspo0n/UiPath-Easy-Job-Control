using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using UiPathEJC.UserInterfaces.Base;

namespace UiPathEJC.UserInterfaces.UserControls
{
    /// <summary>
    /// Interaktionslogik für ProcessItem.xaml
    /// </summary>
    public partial class ProcessItem : UserControl
    {

        public ICommand JobStart
        {
            get => (ICommand)GetValue(JobStartProperty);
            set => SetValue(JobStartProperty, value);
        }
        
        public static readonly DependencyProperty JobStartProperty
            = DependencyProperty.Register(
                "JobStart",
                typeof(ICommand),
                typeof(ProcessItem),
                new PropertyMetadata(default(ICommand))
            );

        public ProcessItem()
        {
            InitializeComponent();
        }
    }
}
