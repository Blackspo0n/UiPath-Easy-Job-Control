using System.Collections.Generic;

namespace UiPathEJC.Components.Settings
{
    class JobsSettings : JsonSettingBase<JobsSettings>
    {
        public new const string DefaultFilename = "JobConfiguration.json";

        public List<IJobSettings> JobSettings;
        
    }
}
