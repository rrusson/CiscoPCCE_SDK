using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sso")
    [XmlRoot("ssoState")]
    public class SsoGlobalState : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("state")]
        public SsoGlobalEnabledState State { get; set; }

        // Path("sso")
        [XmlRoot("results")]
        public class SsoGlobalStateList : BaseApiListBean<SsoGlobalState>
        {
            [XmlArray("ssoStates")]
            [XmlArrayItem("ssoState")]
            public new List<SsoGlobalState>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<SsoGlobalState>? GetItems() => Items;

            public override void SetItems(List<SsoGlobalState>? value) => Items = value;
        }
    }
}