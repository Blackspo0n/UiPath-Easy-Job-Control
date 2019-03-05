using System.Threading.Tasks;
using System.Windows.Input;

namespace UiPathEJC.UserInterfaces.Interface
{
    public interface IAsyncCommand : ICommand
    {
        Task ExecuteAsync(object parameter);
    }
}