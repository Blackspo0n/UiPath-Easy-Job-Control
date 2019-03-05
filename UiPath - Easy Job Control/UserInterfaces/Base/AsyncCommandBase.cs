using System;
using System.Threading.Tasks;
using System.Windows.Input;
using UiPathEJC.Annotations;
using UiPathEJC.UserInterfaces.Interface;

namespace UiPathEJC.UserInterfaces.Base
{
    public abstract class AsyncCommandBase : IAsyncCommand
    {
        public abstract bool CanExecute(object parameter);
        public abstract Task ExecuteAsync([CanBeNull] object parameter);
        public async void Execute([CanBeNull] object parameter)
        {
            await ExecuteAsync(parameter);
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public void RaiseCanExecuteChanged()
        {
            CommandManager.InvalidateRequerySuggested();
        }
    }
}