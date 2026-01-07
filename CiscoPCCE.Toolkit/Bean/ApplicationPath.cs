using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("applicationpath")
    [XmlRoot("applicationPath")]
    public class ApplicationPath : BaseApiBean
    {
        public required ReferenceBean ApplicationInstance { get; set; }

        [XmlElement("applicationPathMembers")]
        [XmlElement("applicationPathMember")]
        public List<ApplicationPathMember>? ApplicationPathMembers { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public string? IdFromRefUrl { get; set; }

        public int? LogicalControllerId { get; set; }

        public string? Name { get; set; }

        public new string? RefURL { get; set; }

        // Path("applicationpath")
        [XmlRoot("results")]
        public class ApplicationPathList : BaseApiListBean<ApplicationPath>
        {
            public override List<ApplicationPath>? GetItems() => Items;

            public override void SetItems(List<ApplicationPath>? value) => Items = value;
        }
    }
}