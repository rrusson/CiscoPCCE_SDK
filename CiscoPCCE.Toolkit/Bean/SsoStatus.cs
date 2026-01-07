using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sso")
    [XmlRoot("ssoStatus")]
    public class SsoStatus : BaseApiBean
    {
        public SsoGlobalEnabledState GlobalSsoState { get; set; }

        public bool? HasIdsCredentials { get; set; }

        public IdSConfigurationState IdSConfigurationState { get; set; }

        public string? IdsBaseUrl { get; set; }

        public SsoOperationState ModeState { get; set; }

        public SsoOperationState RegistrationState { get; set; }

        [XmlElement("##default")]
        [XmlElement("ssoComponentStatus")]
        public List<SsoComponentStatus>? SsoComponentStatuses { get; set; }

        // Path("sso")
        [XmlRoot("results")]
        public class SsoStatusList : BaseApiListBean<SsoStatus>
        {
            public override List<SsoStatus>? GetItems() => Items;

            public override void SetItems(List<SsoStatus>? value) => Items = value;
        }
    }
}