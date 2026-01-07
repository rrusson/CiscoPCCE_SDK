using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agent")
    [XmlRoot("supervisorUserInfo")]
    public class SupervisorUserInfo : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? DomainName { get; set; }

        public string? IdFromRefUrl { get; set; }

        public bool? SsoEnabled { get; set; }

        public bool? Supervisor { get; set; }

        public string? UserName { get; set; }

        // Path("agent")
        [XmlRoot("results")]
        public class SupervisorUserInfoList : BaseApiListBean<SupervisorUserInfo>
        {
            public override List<SupervisorUserInfo>? GetItems() => Items;

            public override void SetItems(List<SupervisorUserInfo>? value) => Items = value;
        }
    }
}