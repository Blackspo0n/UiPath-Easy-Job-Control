using UiPathEJC.Service.Rest.Model;

namespace UiPathEJC.Components.Settings
{
    interface IJobSettings
    {
        string ReferencedJobKey { get; set; }

        StartProcessDto ProcessConfiguration { get; set; }
    }
}
