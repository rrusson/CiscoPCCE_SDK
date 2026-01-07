using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("role")
    [XmlRoot("role")]
    public class Role : BaseApiBean
    {
        [XmlElement("administrators")]
        [XmlElement("administrator")]
        public List<ReferenceBean>? Administrators { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        [XmlElement("accessList")]
        [XmlElement("feature")]
        public List<Feature>? Features { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? Name { get; set; }

        public new string? RefURL { get; set; }

        public bool? SystemDefined { get; set; }

        // Path("role")
        [XmlRoot("results")]
        public class RoleList : BaseApiListBean<Role>
        {
            public override List<Role>? GetItems() => Items;

            public override void SetItems(List<Role>? value) => Items = value;
        }
    }
}