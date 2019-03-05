using UiPathEJC.Service.Rest.Model;

namespace UiPathEJC.UserInterfaces.UserControls.ViewModels.Design
{
    public class DesignProcessItemViewModel : ProcessItemViewModel
    {
        public DesignProcessItemViewModel() : 
            base(new ReleaseDto() { Description = "Das ist eine Designbeschreibung, (Sichtbar nur im Designer)", EnvironmentName = "Test Environment", CurrentVersion = new ReleaseVersionDto(1231211,"1.1.1"), })
        {
            OnPropertyChanged();
        }
    }
}
