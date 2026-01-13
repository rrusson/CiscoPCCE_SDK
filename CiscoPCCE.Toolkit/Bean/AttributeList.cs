using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("attribute")
    [XmlRoot("results")]
    public class AttributeList : BaseApiList<Attribute>
    {
        [XmlArray("attributes")]
        [XmlArrayItem("attribute")]
        public new List<Attribute>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }
    }
}