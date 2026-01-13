using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("ssoComponentStatus")]
    public class SsoComponentStatus : BaseApiBean
    {
        [XmlArray("##default")]
        [XmlArrayItem("apiError")]
        public List<ApiError>? ApiErrors { get; set; }

        [XmlElement("modeState")]
        public SsoOperationState ModeState { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("registrationState")]
        public SsoOperationState RegistrationState { get; set; }

        [XmlElement("ssoTestPath")]
        public string? SsoTestPath { get; set; }
    }
}