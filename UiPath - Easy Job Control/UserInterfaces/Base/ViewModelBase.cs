using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace UiPathEJC.UserInterfaces.Base
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null, [CallerFilePath] string filePath = null)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            Debug.WriteLine($"calling from {Path.GetFileNameWithoutExtension(filePath)} on Property {propertyName}");
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
