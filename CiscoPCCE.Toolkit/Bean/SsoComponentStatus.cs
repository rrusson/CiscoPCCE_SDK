using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sso")
    [XmlRoot("ssoComponentStatus")]
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

        // Path("sso")
        [XmlRoot("results")]
        public class SsoComponentStatusList : BaseApiListBean<SsoComponentStatus>
        {
            public override List<SsoComponentStatus>? GetItems() => Items;

            public override void SetItems(List<SsoComponentStatus>? value) => Items = value;
        }
    }
}