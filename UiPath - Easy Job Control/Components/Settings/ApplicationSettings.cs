using System.Configuration;

namespace UiPathEJC.Components.Settings
{
    public class ApplicationSettings : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        [DefaultSettingValue("true")]
        public bool AutoLogin
        {
            get => (bool)this[nameof(AutoLogin)];
            set => this[nameof(AutoLogin)] = (object)value;
        }

        [UserScopedSetting()]
        [DefaultSettingValue("")]
        public string LastBearerToken
        {
            get => (string)this[nameof(LastBearerToken)];
            set => this[nameof(LastBearerToken)] = (object)value;
        }

        [UserScopedSetting()]
        [DefaultSettingValue("")]
        public string UserName
        {
            get => (string)this[nameof(UserName)];
            set => this[nameof(UserName)] = (object)value;
        }


        [UserScopedSetting()]
        [DefaultSettingValue("Default")]
        public string Tenant
        {
            get => (string)this[nameof(Tenant)];
            set => this[nameof(Tenant)] = (object)value;
        }

        [UserScopedSetting()]
        [DefaultSettingValue("")]
        public string Password
        {
            get => (string)this[nameof(Password)];
            set => this[nameof(Password)] = (object)value;
        }

        [UserScopedSetting()]
        [DefaultSettingValue("")]
        public string OrchestratorInstance
        {
            get => (string)this[nameof(OrchestratorInstance)];
            set => this[nameof(OrchestratorInstance)] = (object)value;
        }
    }
}