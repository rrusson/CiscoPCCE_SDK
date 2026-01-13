using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("ssoStatus")]
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
    }
}