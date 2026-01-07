using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sso")
    [XmlRoot("ssoState")]
    public class SsoGlobalState : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? IdFromRefUrl { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        public new string? RefURL { get; set; }

        public SsoGlobalEnabledState State { get; set; }

        // Path("sso")
        [XmlRoot("results")]
        public class SsoGlobalStateList : BaseApiListBean<SsoGlobalState>
        {
            public override List<SsoGlobalState>? GetItems() => Items;

            public override void SetItems(List<SsoGlobalState>? value) => Items = value;
        }
    }
}