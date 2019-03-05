using System.Windows.Media;

namespace UiPathEJC.UserInterfaces.Interface
{
    public interface IContentViewModel
    {
        string ViewName { get; }
        string ShortName { get; }
        object IconSource { get; }
        bool IsDialogOpen { get; }
        object DialogContent { get; }


    }
}