using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sso")
    [XmlRoot("ssoStatus")]
    public class SsoStatus : BaseApiBean
    {
        [XmlElement("globalSsoState")]
        public SsoGlobalEnabledState GlobalSsoState { get; set; }

        [XmlElement("hasIdsCredentials")]
        public bool? HasIdsCredentials { get; set; }

        [XmlElement("idSConfigurationState")]
        public IdSConfigurationState IdSConfigurationState { get; set; }

        [XmlElement("idsBaseUrl")]
        public string? IdsBaseUrl { get; set; }

        [XmlElement("modeState")]
        public SsoOperationState ModeState { get; set; }

        [XmlElement("registrationState")]
        public SsoOperationState RegistrationState { get; set; }

        [XmlArray("##default")]
        [XmlArrayItem("ssoComponentStatus")]
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