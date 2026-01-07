using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sso")
    [XmlRoot("ssoComponentStatus")]
    public class SsoComponentStatus : BaseApiBean
    {
        [XmlElement("##default")]
        [XmlElement("apiError")]
        public List<ApiError>? ApiErrors { get; set; }

        public SsoOperationState ModeState { get; set; }

        public string? Name { get; set; }

        public new string? RefURL { get; set; }

        public SsoOperationState RegistrationState { get; set; }

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