using UiPathEJC.Service.Rest.Model;
using UiPathEJC.UserInterfaces.Base;

namespace UiPathEJC.UserInterfaces.UserControls.ViewModels
{
    public class ProcessItemViewModel : ViewModelBase
    {
        #region Properties
        private ReleaseDto _process;

        public ReleaseDto Process
        {
            set
            {
                if (value.Equals(_process)) return;
                _process = value;
                OnPropertyChanged();
            }
            get => _process;
        }

        #endregion

        #region Commands
        


        #endregion

        public ProcessItemViewModel(ReleaseDto process)
        {
            Process = process;
        }

    }
}