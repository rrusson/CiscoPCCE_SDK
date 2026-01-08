using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("attribute")
    [XmlRoot("results")]
    public class AttributeList : BaseApiBean
    {
        [XmlArray("attributes")]
        [XmlArrayItem("attribute")]
        public List<AttributeBase>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("attribute")
        [XmlRoot("results")]
        public class AttributeListList : BaseApiListBean<AttributeList>
        {
            public override List<AttributeList>? GetItems() => Items;

            public override void SetItems(List<AttributeList>? value) => Items = value;
        }
    }
}