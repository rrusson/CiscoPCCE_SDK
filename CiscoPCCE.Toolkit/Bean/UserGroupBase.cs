using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("administrator")
    [XmlRoot("userGroupBase")]
    public class UserGroupBase : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? DomainName { get; set; }

        public string? IdFromRefUrl { get; set; }

        public new string? RefURL { get; set; }

        public bool? SsoEnabled { get; set; }

        public bool? Supervisor { get; set; }

        public string? UserName { get; set; }

        // Path("administrator")
        [XmlRoot("results")]
        public class UserGroupBaseList : BaseApiListBean<UserGroupBase>
        {
            public override List<UserGroupBase>? GetItems() => Items;

            public override void SetItems(List<UserGroupBase>? value) => Items = value;
        }
    }
}