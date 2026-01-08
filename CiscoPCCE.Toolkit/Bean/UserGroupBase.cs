using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("administrator")
    [XmlRoot("userGroupBase")]
    public class UserGroupBase : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("domainName")]
        public string? DomainName { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("ssoEnabled")]
        public bool? SsoEnabled { get; set; }

        [XmlElement("supervisor")]
        public bool? Supervisor { get; set; }

        [XmlElement("userName")]
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